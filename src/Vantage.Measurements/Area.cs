using Vantage.Measurements.Registration;
using Vantage.Measurements.Units.Area;
using Vantage.Measurements.Units.Length;

namespace Vantage.Measurements
{
    public class Area : Measurement<Area, IAreaUnit>
    {
        public static Square<Meter> DefaultUnit => UnitRegistry.Get<Square<Meter>>();

        public Area(double value, IAreaUnit unit) : base(value, unit)
        {
            BaseValue = unit.ToSquareMeters(value);
        }

        public Area(IMeasurement<IAreaUnit> measurement) : base(measurement)
        {
            BaseValue = measurement.Unit.ToSquareMeters(measurement.Value);
        }

        public static Area SquareMeters(double value)
            => new Area(value, DefaultUnit);

        public static Area OfType<T>(double value) where T : class, IAreaUnit
            => new Area(value, UnitRegistry.Get<T>());

        public static Area Square<T>(double value) where T : class, ILengthUnit
            => new Area(value, UnitRegistry.Get<Square<T>>());

        protected override IAreaUnit BaseUnit => DefaultUnit;

        public override Area ConvertTo(IAreaUnit targetUnit)
            => new Area(targetUnit.FromSquareMeters(BaseValue), targetUnit);

        protected override Measurement<Area, IAreaUnit> Wrap(IMeasurement<IAreaUnit> measurement)
            => measurement is Area area ? area : new Area(measurement);

        protected override Measurement<Area, IAreaUnit> Create(double value, IAreaUnit unit)
            => new Area(value, unit);
    }
}