using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vantage.Measurements.Registration
{
    internal class Registry : Dictionary<Type, Registration>
    {
        private static readonly Type UnitType = typeof(IUnit);
        private static readonly Type CompositeUnitType = typeof(ICompositeUnit);

        public Registry()
        {

        }

        public void Add(IUnit unit)
        {
            var registration = new Registration(unit);
            if (ContainsKey(registration.Type))
                return;

            Add(registration.Type, registration);
        }

        public void RegisterAssembly()
        {

        }

        private static bool IsRegistrableUnit(Type type)
        {
            if (!type.IsClass || type.IsAbstract)
                return false;

            var interfaces = type.GetInterfaces();
            return interfaces.Any(IsUnit) && interfaces.FirstOrDefault(IsCompositeUnit) == null;
        }

        private static bool IsUnit(Type type)
            => type == UnitType;

        private static bool IsCompositeUnit(Type type)
            => type == CompositeUnitType;
    }
}
