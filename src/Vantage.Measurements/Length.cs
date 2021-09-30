using System.Dynamic;
using Vantage.Measurements.Prefixes;
using Vantage.Measurements.Registration;
using Vantage.Measurements.Units;
using Vantage.Measurements.Units.DigitalStorage;
using Vantage.Measurements.Units.Length;

namespace Vantage.Measurements
{
    public class Length : Measurement<Length, ILengthUnit>
    {
        public static Meter DefaultUnit => UnitRegistry.Get<Meter>();

        public Length(double value, ILengthUnit unit) : base(value, unit)
        {
            BaseValue = unit.ToMeters(value);
        }

        public Length(IMeasurement<ILengthUnit> measurement) : base(measurement)
        {
            BaseValue = measurement.Unit.ToMeters(measurement.Value);
        }

        public static Length Meters(double value)
                    => new Length(value, DefaultUnit);

        public static Length OfType<T>(double value) where T : class, ILengthUnit
            => new Length(value, UnitRegistry.Get<T>());

        public static Length OfType<TPrefix, TLength>(double value) where TPrefix : IPrefix where TLength : class, ILengthUnit
            => OfType<PrefixedLength<TPrefix, TLength>>(value);

        protected override ILengthUnit BaseUnit => DefaultUnit;

        public override Length ConvertTo(ILengthUnit targetUnit)
            => new Length(targetUnit.FromMeters(BaseValue), targetUnit);

        protected override Measurement<Length, ILengthUnit> Wrap(IMeasurement<ILengthUnit> measurement)
            => measurement is Length length ? length : new Length(measurement);

        protected override Measurement<Length, ILengthUnit> Create(double value, ILengthUnit unit)
            => new Length(value, unit);
    }
}
