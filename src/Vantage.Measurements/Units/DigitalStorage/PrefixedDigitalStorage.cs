using Vantage.Measurements.Prefixes;
using Vantage.Measurements.Units.Length;

namespace Vantage.Measurements.Units.DigitalStorage
{
    public class PrefixedDigitalStorage<TPrefix, TUnit> : PrefixedUnit<TPrefix, TUnit>, IDigitalStorageUnit
        where TPrefix : IPrefix
        where TUnit : class, IDigitalStorageUnit
    {
        public double ToBytes(double value)
            => Unit.ToBytes(value) * Prefix.Scale;

        public double FromBytes(double value)
            => Unit.FromBytes(value) / Prefix.Scale;
    }
}
