using System;
using System.Collections.Generic;
using System.Text;
using Vantage.Measurements.Prefixes;

namespace Vantage.Measurements.Units.Length
{
    public class PrefixedLength<TPrefix, TUnit> : PrefixedUnit<TPrefix, TUnit>, ILengthUnit
        where TPrefix : IPrefix
        where TUnit : class, ILengthUnit
    {
        public double ToMeters(double value)
            => Unit.ToMeters(value) * Prefix.Scale;

        public double FromMeters(double value)
            => Unit.FromMeters(value) / Prefix.Scale;
    }
}
