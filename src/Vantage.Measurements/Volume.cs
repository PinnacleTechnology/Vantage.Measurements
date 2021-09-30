using Vantage.Measurements.Registration;
using Vantage.Measurements.Units.Length;
using Vantage.Measurements.Units.Volume;

namespace Vantage.Measurements
{
    public class Volume : Measurement<Volume, IVolumeUnit>
    {
        public static Cubic<Meter> DefaultUnit => UnitRegistry.Get<Cubic<Meter>>();

        public Volume(double value, IVolumeUnit unit) : base(value, unit)
        {
            BaseValue = unit.ToCubicMeters(value);
        }

        public Volume(IMeasurement<IVolumeUnit> measurement) : base(measurement)
        {
            BaseValue = measurement.Unit.ToCubicMeters(measurement.Value);
        }

        public static Volume CubicMeters(double value)
            => new Volume(value, DefaultUnit);

        public static Volume OfType<T>(double value) where T : class, IVolumeUnit
            => new Volume(value, UnitRegistry.Get<T>());

        public static Volume Cubic<T>(double value) where T : class, ILengthUnit
            => new Volume(value, UnitRegistry.Get<Cubic<T>>());

        protected override IVolumeUnit BaseUnit => DefaultUnit;

        public override Volume ConvertTo(IVolumeUnit targetUnit)
            => new Volume(targetUnit.FromCubicMeters(BaseValue), targetUnit);

        protected override Measurement<Volume, IVolumeUnit> Wrap(IMeasurement<IVolumeUnit> measurement)
            => measurement is Volume volume ? volume : new Volume(measurement);

        protected override Measurement<Volume, IVolumeUnit> Create(double value, IVolumeUnit unit)
            => new Volume(value, unit);
    }
}