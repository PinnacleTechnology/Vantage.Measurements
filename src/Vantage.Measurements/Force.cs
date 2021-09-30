using Vantage.Measurements.Units.Length;
using Vantage.Measurements.Units.Force;
using Vantage.Measurements.Units.Time;
using Vantage.Measurements.Registration;

namespace Vantage.Measurements
{
    public class Force : Measurement<Force, IForceUnit>
    {
        public static Newton DefaultUnit => UnitRegistry.Get<Newton>();

        public Force(double value, IForceUnit unit) : base(value, unit)
        {
            BaseValue = unit.ToNewtons(value);
        }

        public Force(IMeasurement<IForceUnit> measurement) : base(measurement)
        {
            BaseValue = measurement.Unit.ToNewtons(measurement.Value);
        }

        public static Force Newtons(double value)
            => new Force(value, DefaultUnit);

        public static Force OfType<T>(double value) where T : class, IForceUnit
            => new Force(value, UnitRegistry.Get<T>());

        protected override IForceUnit BaseUnit => DefaultUnit;

        public override Force ConvertTo(IForceUnit targetUnit)
            => new Force(targetUnit.FromNewtons(BaseValue), targetUnit);

        protected override Measurement<Force, IForceUnit> Wrap(IMeasurement<IForceUnit> measurement)
            => measurement is Force force ? force : new Force(measurement);

        protected override Measurement<Force, IForceUnit> Create(double value, IForceUnit unit)
            => new Force(value, unit);
    }
}