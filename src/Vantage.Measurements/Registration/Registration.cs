using System;
using System.Linq;
using System.Reflection;
using Vantage.Measurements.Prefixes;

namespace Vantage.Measurements.Registration
{
    internal class Registration : IEquatable<Registration>
    {
        private static readonly Type PrefixedUnitInterfaceType = typeof(IPrefixedUnit<,>);
        private static readonly Type CompositeUnitInterfaceType = typeof(ICompositeUnit);

        public Type Type { get; }

        public IUnit Unit { get; }

        public Type CoreUnitType { get; }

        public Type? PrefixType { get; }

        public Type? PrefixedUnitType { get; }

        public bool HasPrefix => PrefixType != null && PrefixedUnitType != null;

        public Type[] CompositeTypes { get; }

        public bool IsCompositeType => CompositeTypes.Any();

        public Registration(IUnit unit)
        {
            Unit = unit;
            Type = unit.GetType();
            CoreUnitType = GetCoreUnitType(Type);

            var (type, unitType) = DeterminePrefix();
            PrefixType = type;
            PrefixedUnitType = unitType;
            CompositeTypes = PopulateCompositeTypes();
        }

        public bool Equals(Registration? other)
        {
            if (other is null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Type == other.Type;
        }

        public override bool Equals(object? obj)
        {
            return obj is Registration reg && Equals(reg);
        }

        public override int GetHashCode()
        {
            return Type.GetHashCode();
        }

        private static Type GetCoreUnitType(Type type)
        {
            return type.GetInterfaces().Single(x => x.GetCustomAttribute<CoreUnitTypeAttribute>() != null);
        }

        private (Type? type, Type? unitType) DeterminePrefix()
        {
            var prefixedInterface = Type.GetInterface(PrefixedUnitInterfaceType.Name);
            if (prefixedInterface == null)
                return (null, null);

            var args = prefixedInterface.GetGenericArguments();
            var prefix = args.FirstOrDefault(x => x.GetInterface(nameof(IPrefix)) != null);
            var prefixedUnit = args.FirstOrDefault(x => x.GetInterface(nameof(IUnit)) != null);
            return (prefix, prefixedUnit);
        }

        private Type[] PopulateCompositeTypes()
        {
            var compositeInterface = Type.GetInterface(CompositeUnitInterfaceType.Name);
            if (compositeInterface == null)
                return Array.Empty<Type>();

            var genericCompositeType = Type.GetInterfaces().FirstOrDefault(x => x.IsGenericType && x.Name.Equals(CompositeUnitInterfaceType.Name));
            return genericCompositeType?.GetGenericArguments() ?? Array.Empty<Type>();
        }
    }
}
