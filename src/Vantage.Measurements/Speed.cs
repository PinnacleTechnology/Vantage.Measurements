using Vantage.Measurements.Registration;
using Vantage.Measurements.Units.Length;
using Vantage.Measurements.Units.Speed;
using Vantage.Measurements.Units.Time;

namespace Vantage.Measurements
{
    public class Speed : Measurement<Speed, ISpeedUnit>
    {
        public static CompositeSpeed<Meter, Second> DefaultUnit => UnitRegistry.Get<CompositeSpeed<Meter, Second>>();

        public Speed(double value, ISpeedUnit unit) : base(value, unit)
        {
            BaseValue = unit.ToMetersPerSecond(value);
        }

        public Speed(IMeasurement<ISpeedUnit> measurement) : base(measurement)
        {
            BaseValue = measurement.Unit.ToMetersPerSecond(measurement.Value);
        }

        public static Speed MetersPerSecond(double value)
            => new Speed(value, DefaultUnit);

        public static Speed OfType<T>(double value) where T : class, ISpeedUnit
            => new Speed(value, UnitRegistry.Get<T>());

        protected override ISpeedUnit BaseUnit => DefaultUnit;

        public override Speed ConvertTo(ISpeedUnit targetUnit)
            => new Speed(targetUnit.FromMetersPerSecond(BaseValue), targetUnit);

        protected override Measurement<Speed, ISpeedUnit> Wrap(IMeasurement<ISpeedUnit> measurement)
            => measurement is Speed speed ? speed : new Speed(measurement);

        protected override Measurement<Speed, ISpeedUnit> Create(double value, ISpeedUnit unit)
            => new Speed(value, unit);
    }
}