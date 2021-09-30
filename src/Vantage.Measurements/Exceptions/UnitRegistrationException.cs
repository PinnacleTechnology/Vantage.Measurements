using System;
using System.Security.Cryptography;

namespace Vantage.Measurements.Exceptions
{
    public class UnitRegistrationException<T> : Exception where T : IUnit
    {
        public UnitRegistrationException() : base(FormatMessage())
        {

        }

        private static string FormatMessage()
        {
            var targetType = typeof(T);
            return $"The target type '{targetType.Name}' is not registered";
        }
    }
}
