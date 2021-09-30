using System;
using System.Globalization;
using Vantage.Measurements.Registration;
using Vantage.Measurements.Units;
using Vantage.Measurements.Units.Angle;
using Vantage.Numerics;

namespace Vantage.Measurements
{
    public class Angle : Measurement<Angle, IAngleUnit>
    {
        public static Radian DefaultUnit => UnitRegistry.Get<Radian>();

        public Angle(double value, IAngleUnit unit) : base(value, unit)
        {
            BaseValue = unit.ToRadians(value);
        }

        public Angle(IMeasurement<IAngleUnit> measurement) : base(measurement)
        {
            BaseValue = measurement.Unit.ToRadians(measurement.Value);
        }

        public static Angle Radians(double value)
            => new Angle(value, DefaultUnit);

        public static Angle OfType<T>(double value) where T : class, IAngleUnit
            => new Angle(value, UnitRegistry.Get<T>());

        protected override IAngleUnit BaseUnit => DefaultUnit;

        public override Angle ConvertTo(IAngleUnit targetUnit)
            => new Angle(targetUnit.FromRadians(BaseValue), targetUnit);

        protected override Measurement<Angle, IAngleUnit> Wrap(IMeasurement<IAngleUnit> measurement)
            => measurement is Angle angle ? angle : new Angle(measurement);

        protected override Measurement<Angle, IAngleUnit> Create(double value, IAngleUnit unit)
            => new Angle(value, unit);
    }
}
