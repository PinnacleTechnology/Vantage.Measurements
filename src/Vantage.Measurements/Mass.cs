using Vantage.Measurements.Registration;
using Vantage.Measurements.Units.Mass;

namespace Vantage.Measurements
{
    public class Mass : Measurement<Mass, IMassUnit>
    {
        public static Kilogram DefaultUnit => UnitRegistry.Get<Kilogram>();

        public Mass(double value, IMassUnit unit) : base(value, unit)
        {
            BaseValue = unit.ToKilograms(value);
        }

        public Mass(IMeasurement<IMassUnit> measurement) : base(measurement)
        {
            BaseValue = measurement.Unit.ToKilograms(measurement.Value);
        }

        public static Mass Kilograms(double value)
            => new Mass(value, DefaultUnit);

        public static Mass OfType<T>(double value) where T : class, IMassUnit
            => new Mass(value, UnitRegistry.Get<T>());

        protected override IMassUnit BaseUnit => DefaultUnit;

        public override Mass ConvertTo(IMassUnit targetUnit)
            => new Mass(targetUnit.FromKilograms(BaseValue), targetUnit);

        protected override Measurement<Mass, IMassUnit> Wrap(IMeasurement<IMassUnit> measurement)
            => measurement is Mass mass ? mass : new Mass(measurement);

        protected override Measurement<Mass, IMassUnit> Create(double value, IMassUnit unit)
            => new Mass(value, unit);
    }
}