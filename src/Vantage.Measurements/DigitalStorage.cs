using Vantage.Measurements.Prefixes;
using Vantage.Measurements.Registration;
using Vantage.Measurements.Units.DigitalStorage;

namespace Vantage.Measurements
{
    public class DigitalStorage : Measurement<DigitalStorage, IDigitalStorageUnit>
    {
        public static Byte DefaultUnit => UnitRegistry.Get<Byte>();

        public DigitalStorage(double value, IDigitalStorageUnit unit) : base(value, unit)
        {
            BaseValue = unit.ToBytes(value);
        }

        public DigitalStorage(IMeasurement<IDigitalStorageUnit> measurement) : base(measurement)
        {
            BaseValue = measurement.Unit.ToBytes(measurement.Value);
        }

        public static DigitalStorage Bytes(double value)
            => new DigitalStorage(value, DefaultUnit);

        public static DigitalStorage OfType<T>(double value) where T : class, IDigitalStorageUnit
            => new DigitalStorage(value, UnitRegistry.Get<T>());

        public static DigitalStorage OfType<TPrefix, TUnit>(double value) where TPrefix : IPrefix where TUnit : class, IDigitalStorageUnit
            => new DigitalStorage(value, UnitRegistry.Get<PrefixedDigitalStorage<TPrefix, TUnit>>());

        protected override IDigitalStorageUnit BaseUnit => DefaultUnit;

        public override DigitalStorage ConvertTo(IDigitalStorageUnit targetUnit)
            => new DigitalStorage(targetUnit.FromBytes(BaseValue), targetUnit);

        protected override Measurement<DigitalStorage, IDigitalStorageUnit> Wrap(IMeasurement<IDigitalStorageUnit> measurement)
            => measurement is DigitalStorage digitalStorage ? digitalStorage : new DigitalStorage(measurement);

        protected override Measurement<DigitalStorage, IDigitalStorageUnit> Create(double value, IDigitalStorageUnit unit)
            => new DigitalStorage(value, unit);
    }
}