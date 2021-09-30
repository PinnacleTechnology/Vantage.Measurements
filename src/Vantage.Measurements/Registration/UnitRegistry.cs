using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Vantage.Measurements;
using Vantage.Measurements.Exceptions;
using Vantage.Measurements.Prefixes;
using Vantage.Measurements.Units;
using Vantage.Measurements.Units.Length;

namespace Vantage.Measurements.Registration
{
    public static class UnitRegistry
    {
        private static readonly Dictionary<Type, Registration> Registry;
        private static readonly Dictionary<Type, IPrefix> Prefixes;
        private static readonly List<Type> CompositeTypeDefinitions;
        private static readonly List<PrefixedUnitDefinition> PrefixedUnitTypeDefinitions;
        private static readonly Type PrefixType = typeof(IPrefix);
        private static readonly Lazy<IEnumerable<Type>> LocalTypesLazy;

        static UnitRegistry()
        {
            Registry = new Dictionary<Type, Registration>();
            LocalTypesLazy = new Lazy<IEnumerable<Type>>(() => Assembly.GetExecutingAssembly().GetExportedTypes());

            Prefixes = PopulatePrefixes();
            CompositeTypeDefinitions = PopulateCompositeTypeDefinitions().ToList();
            PrefixedUnitTypeDefinitions = PopulatePrefixedUnitTypeDefinitions().ToList();
            LoadAssemblyUnits();
        }

        private static IEnumerable<Type> LocalTypes => LocalTypesLazy.Value;

        public static void Add(IUnit unit)
        {
            if (GetUnitSafe(unit.GetType()).IsNull())
                RegisterUnit(unit);
        }

        public static void Add<T>() where T : class, IUnit, new()
        {
            Add<T>(null);
        }

        public static void Add<T>(Action<T>? configure) where T : class, IUnit, new()
        {
            if (GetUnitSafe<T>().IsNotNull())
                return;

            CreateAndConfigure(configure);
        }

        public static void Configure<T>(Action<T> configure) where T : class, IUnit, new()
        {
            var registration = GetRegistration(typeof(T));
            if (registration?.Unit is T unit)
                configure(unit);
            else
                CreateAndConfigure(configure);
        }

        public static void Configure<TPrefix, TUnit>(Action<IUnit> configure) where TPrefix : IPrefix where TUnit : IUnit
        {
            var registration = Registry.Values
                .FirstOrDefault(x => x.HasPrefix && x.PrefixedUnitType == typeof(TUnit) && x.PrefixType == typeof(TPrefix));

            if (registration != null)
                configure(registration.Unit);
            else
                throw new InvalidOperationException();
        }

        public static void ScanAssembly(Assembly assembly)
        {
            assembly
                .GetExportedTypes()
                .Where(IsValidUnit)
                .ToList()
                .ForEach(ProcessUnit);
        }

        public static T Get<T>() where T : class, IUnit
        {
            return GetUnitSafe<T>() ?? throw new UnitRegistrationException<T>();
        }

        public static T GetPrefix<T>() where T : IPrefix
        {
            var targetType = typeof(T);
            if (Prefixes.ContainsKey(targetType))
                return (T)Prefixes[targetType];

            throw new InvalidOperationException();
        }

        public static Dictionary<Type, Type[]> GetCoreUnitIndex()
        {
            return Registry.Values
                .GroupBy(x => x.CoreUnitType)
                .ToDictionary(x => x.Key, x => x.Select(y => y.Type).ToArray());
        }

        public static Type? GetCoreUnitType(IUnit unit)
            => GetRegistration(unit.GetType())?.CoreUnitType;

        private static void CreateAndConfigure<T>(Action<T>? configure) where T : class, IUnit, new()
        {
            var unit = new T();
            RegisterUnit(unit);
            configure?.Invoke(unit);
        }



        private static void ProcessUnit(Type unitType)
        {
            if (unitType.ContainsGenericParameters)
            {

            }




            var prefix = unitType.BaseType?.GetInterfaces().FirstOrDefault(x => x.IsGenericType && x.GetGenericTypeDefinition() == PrefixType);
            var unit = prefix != null ? CreateGenericUnit(unitType, prefix) : Activator.CreateInstance(unitType) as IUnit;
            if (unit == null)
                throw new UnitConstructionException(unitType);

            RegisterUnit(unit);
        }

        private static bool IsValidUnit(Type type)
        {
            if (!type.IsClass || type.IsAbstract)
                return false;

            var interfaces = type.GetInterfaces();
            return interfaces.Any(IsUnit) && interfaces.FirstOrDefault(IsCompositeUnit) == null;
        }

        private static bool IsUnit(Type type)
            => type == typeof(IUnit);

        private static bool IsCompositeUnit(Type type)
            => type == typeof(ICompositeUnit);

        private static T? GetUnitSafe<T>() where T : class, IUnit
            => (T?)GetUnitSafe(typeof(T));

        private static IUnit? GetUnitSafe(Type unitType)
            => unitType.GetInterfaces().Any(IsCompositeUnit) ? HandleCompositeUnit(unitType) : GetRegistration(unitType)?.Unit;

        private static IUnit? HandleCompositeUnit(Type unitType)
        {
            if (Registry.TryGetValue(unitType, out var registration))
                return registration.Unit;

            var interfaces = unitType.GetInterfaces();
            foreach (var compositeType in CompositeTypeDefinitions)
            {
                var composite = interfaces.FirstOrDefault(x => x.IsGenericType && x.GetGenericTypeDefinition() == compositeType);
                if (composite == null)
                    continue;

                var unit = CreateGenericUnit(unitType, composite) ?? throw new UnitConstructionException(unitType);
                RegisterUnit(unit);
                return unit;
            }

            return null;
        }

        private static void RegisterUnit(IUnit unit)
        {
            var registration = new Registration(unit);
            Registry.Add(registration.Type, registration);

            if (!registration.HasPrefix)
                RegisterAllPrefixesForUnit(registration);
        }

        private static void RegisterAllPrefixesForUnit(Registration registration)
        {
            if (registration.IsCompositeType)
            {
                return;
            }

            var prefixedUnitDefinition = PrefixedUnitTypeDefinitions.FirstOrDefault(x => x.CoreUnitType == registration.CoreUnitType);
            if (prefixedUnitDefinition == null)
                return;

            Prefixes
                .Select(x => CreateGenericUnit(prefixedUnitDefinition.Type, x.Key, registration.Type))
                .Select(x => new Registration(x))
                .ToList()
                .ForEach(x => Registry.Add(x.Type, x));
        }

        private static Registration? GetRegistration(Type unitType)
            => Registry.TryGetValue(unitType, out var registration) ? registration : default;

        private static IUnit? CreateGenericUnit(Type targetType, Type genericParam)
        {
            var typeMappings = genericParam.GetGenericArguments().ToDictionary(x => x, GetUnitSafe);
            var constructableType = GetConstructableType(targetType, typeMappings.Keys.ToArray());
            var constructors = constructableType.GetTypeInfo().DeclaredConstructors;

            if (constructors.Any(x => !x.GetParameters().Any()))
            {
                return (IUnit?)Activator.CreateInstance(constructableType);
            }

            // TODO: map possible constructors
            return (IUnit?)Activator.CreateInstance(constructableType, typeMappings.Values.ToArray<object>());
        }

        private static IUnit CreateGenericUnit(Type targetType, params Type[] genericParams)
        {
            var constructableType = GetConstructableType(targetType, genericParams);
            var constructors = constructableType.GetTypeInfo().DeclaredConstructors;

            if (constructors.Any(x => !x.GetParameters().Any()))
            {
                return Activator.CreateInstance(constructableType) is IUnit unit ? unit : throw new InvalidOperationException();
            }

            throw new NotImplementedException();
            // TODO: map possible constructors
            //return (IUnit?)Activator.CreateInstance(constructableType, typeMappings.Values.ToArray<object>());
        }


        private static Type GetConstructableType(Type targetType, params Type[] types)
            => targetType.IsGenericTypeDefinition ? targetType.MakeGenericType(types) : targetType;

        private static void LoadAssemblyUnits()
            => ScanAssembly(Assembly.GetExecutingAssembly());

        private static IEnumerable<Type> PopulateCompositeTypeDefinitions()
        {
            var compositeType = typeof(ICompositeUnit);
            return LocalTypes.Where(x => x.IsInterface && x.IsGenericType && x.GetInterfaces().Contains(compositeType));
        }

        private static IEnumerable<PrefixedUnitDefinition> PopulatePrefixedUnitTypeDefinitions()
        {
            var prefixedUnit = typeof(IPrefixedUnit<,>);

            return LocalTypes
                .Where(x => x.IsClass && !x.IsAbstract && x.IsGenericType && x.GetInterface(prefixedUnit.Name) != null)
                .Select(x => new PrefixedUnitDefinition(x));
        }

        private static Dictionary<Type, IPrefix> PopulatePrefixes()
        {
            return LocalTypes
                .Where(IsValidPrefix)
                .Select(BuildPrefix)
                .ToDictionary(x => x.GetType());
        }

        private static bool IsValidPrefix(Type type)
            => type.IsClass && !type.IsAbstract && type.GetInterfaces().Contains(PrefixType);

        private static IPrefix BuildPrefix(Type type)
            => Activator.CreateInstance(type) is IPrefix prefix ? prefix : throw new InvalidOperationException();

    }
}