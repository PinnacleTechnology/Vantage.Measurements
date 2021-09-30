using System;
using System.Collections.Generic;
using System.Text;
using Vantage.Measurements.Prefixes;

namespace Vantage.Measurements.Units.Time
{
    public class PrefixedTime<TPrefix, TUnit> : PrefixedUnit<TPrefix, TUnit>, ITimeUnit
        where TPrefix : IPrefix
        where TUnit : class, ITimeUnit
    {
        public double ToSeconds(double value)
            => Unit.ToSeconds(value) * Prefix.Scale;

        public double FromSeconds(double value)
            => Unit.FromSeconds(value) / Prefix.Scale;
    }
}
