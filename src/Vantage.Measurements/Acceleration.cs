using Vantage.Measurements.Units.Length;
using Vantage.Measurements.Units.Acceleration;
using Vantage.Measurements.Units.Time;
using Vantage.Measurements.Registration;

namespace Vantage.Measurements
{
    public class Acceleration : Measurement<Acceleration, IAccelerationUnit>
    {
        public static CompositeAcceleration<Meter, Second> DefaultUnit => UnitRegistry.Get<CompositeAcceleration<Meter, Second>>();

        public Acceleration(double value, IAccelerationUnit unit) : base(value, unit)
        {
            BaseValue = unit.ToMetersPerSecondSquared(value);
        }

        public Acceleration(IMeasurement<IAccelerationUnit> measurement) : base(measurement)
        {
            BaseValue = measurement.Unit.ToMetersPerSecondSquared(measurement.Value);
        }

        public static Acceleration MetersPerSecondSquared(double value)
            => new Acceleration(value, DefaultUnit);

        public static Acceleration OfType<T>(double value) where T : class, IAccelerationUnit
            => new Acceleration(value, UnitRegistry.Get<T>());

        protected override IAccelerationUnit BaseUnit => DefaultUnit;

        public override Acceleration ConvertTo(IAccelerationUnit targetUnit)
            => new Acceleration(targetUnit.FromMetersPerSecondSquared(BaseValue), targetUnit);

        protected override Measurement<Acceleration, IAccelerationUnit> Wrap(IMeasurement<IAccelerationUnit> measurement)
            => measurement is Acceleration acceleration ? acceleration : new Acceleration(measurement);

        protected override Measurement<Acceleration, IAccelerationUnit> Create(double value, IAccelerationUnit unit)
            => new Acceleration(value, unit);
    }
}