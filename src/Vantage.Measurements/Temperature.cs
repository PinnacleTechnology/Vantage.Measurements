using Vantage.Measurements.Registration;
using Vantage.Measurements.Units.Temperature;

namespace Vantage.Measurements
{
    public class Temperature : Measurement<Temperature, ITemperatureUnit>
    {
        public static Kelvin DefaultUnit => UnitRegistry.Get<Kelvin>();

        public Temperature(double value, ITemperatureUnit unit) : base(value, unit)
        {
            BaseValue = unit.ToKelvin(value);
        }

        public Temperature(IMeasurement<ITemperatureUnit> measurement) : base(measurement)
        {
            BaseValue = measurement.Unit.ToKelvin(measurement.Value);
        }

        public static Temperature Kelvin(double value)
            => new Temperature(value, DefaultUnit);

        public static Temperature OfType<T>(double value) where T : class, ITemperatureUnit
            => new Temperature(value, UnitRegistry.Get<T>());

        protected override ITemperatureUnit BaseUnit => DefaultUnit;

        public override Temperature ConvertTo(ITemperatureUnit targetUnit)
            => new Temperature(targetUnit.FromKelvin(BaseValue), targetUnit);

        protected override Measurement<Temperature, ITemperatureUnit> Wrap(IMeasurement<ITemperatureUnit> measurement)
            => measurement is Temperature time ? time : new Temperature(measurement);

        protected override Measurement<Temperature, ITemperatureUnit> Create(double value, ITemperatureUnit unit)
            => new Temperature(value, unit);
    }
}