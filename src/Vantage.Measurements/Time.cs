using Vantage.Measurements.Registration;
using Vantage.Measurements.Units.Time;

namespace Vantage.Measurements
{
    public class Time : Measurement<Time, ITimeUnit>
    {
        public static Second DefaultUnit => UnitRegistry.Get<Second>();

        public Time(double value, ITimeUnit unit) : base(value, unit)
        {
            BaseValue = unit.ToSeconds(value);
        }

        public Time(IMeasurement<ITimeUnit> measurement) : base(measurement)
        {
            BaseValue = measurement.Unit.ToSeconds(measurement.Value);
        }

        public static Time Seconds(double value)
            => new Time(value, DefaultUnit);

        public static Time OfType<T>(double value) where T : class, ITimeUnit
            => new Time(value, UnitRegistry.Get<T>());

        protected override ITimeUnit BaseUnit => DefaultUnit;

        public override Time ConvertTo(ITimeUnit targetUnit)
            => new Time(targetUnit.FromSeconds(BaseValue), targetUnit);

        protected override Measurement<Time, ITimeUnit> Wrap(IMeasurement<ITimeUnit> measurement)
            => measurement is Time time ? time : new Time(measurement);

        protected override Measurement<Time, ITimeUnit> Create(double value, ITimeUnit unit)
            => new Time(value, unit);
    }
}