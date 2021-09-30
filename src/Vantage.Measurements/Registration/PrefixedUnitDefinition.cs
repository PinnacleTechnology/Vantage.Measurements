using System;
using System.Linq;
using System.Reflection;

namespace Vantage.Measurements.Registration
{
    public class PrefixedUnitDefinition
    {
        public Type Type { get; }
        public Type CoreUnitType { get; }

        public PrefixedUnitDefinition(Type type)
        {
            Type = type;
            CoreUnitType = GetCoreUnitType(Type);
        }

        private static Type GetCoreUnitType(Type type)
        {
            return type.GetInterfaces().FirstOrDefault(x => x.GetCustomAttribute<CoreUnitTypeAttribute>() != null);
        }
    }
}