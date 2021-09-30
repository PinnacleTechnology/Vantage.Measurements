using System;

namespace Vantage.Measurements.Exceptions
{
    public class UnitConstructionException : Exception
    {
        public UnitConstructionException(Type targetType) : base(FormatMessage(targetType))
        {
            
        }

        private static string FormatMessage(Type targetType)
        {
            return $"Failed to construct target '{targetType.Name}'";
        }
    }
}