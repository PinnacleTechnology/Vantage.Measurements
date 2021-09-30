using System;
using Vantage.Measurements;
using Vantage.Measurements.Prefixes;
using Vantage.Measurements.Registration;
using Vantage.Measurements.Units;
using Vantage.Measurements.Units.DigitalStorage;
using Vantage.Measurements.Units.Length;
using Vantage.Numerics;

namespace Vantage.Measurements
{
    public static partial class Extensions
    {
        #region Operators

        public static bool IsEqualTo(this IMeasurement<ILengthUnit> left, IMeasurement<ILengthUnit> right, double precision = Precision.Default)
            => left.ValueInMeters().IsEqualTo(right.ValueInMeters(), precision);

        public static bool IsNotEqualTo(this IMeasurement<ILengthUnit> left, IMeasurement<ILengthUnit> right, double precision = Precision.Default)
            => left.ValueInMeters().IsNotEqualTo(right.ValueInMeters(), precision);

        public static bool IsGreaterThan(this IMeasurement<ILengthUnit> left, IMeasurement<ILengthUnit> right, double precision = Precision.Default)
            => left.ValueInMeters().IsGreaterThan(right.ValueInMeters(), precision);

        public static bool IsGreaterThanOrEqualTo(this IMeasurement<ILengthUnit> left, IMeasurement<ILengthUnit> right, double precision = Precision.Default)
            => left.ValueInMeters().IsGreaterThanOrEqualTo(right.ValueInMeters(), precision);

        public static bool IsLessThan(this IMeasurement<ILengthUnit> left, IMeasurement<ILengthUnit> right, double precision = Precision.Default)
            => left.ValueInMeters().IsLessThan(right.ValueInMeters(), precision);

        public static bool IsLessThanOrEqualTo(this IMeasurement<ILengthUnit> left, IMeasurement<ILengthUnit> right, double precision = Precision.Default)
            => left.ValueInMeters().IsLessThanOrEqualTo(right.ValueInMeters(), precision);

        public static Length Offset(this IMeasurement<ILengthUnit> measurement, double scalar)
            => new Length(measurement) + scalar;

        public static Length Scale(this IMeasurement<ILengthUnit> measurement, double scalar)
            => new Length(measurement) * scalar;

        public static Length Add(this IMeasurement<ILengthUnit> left, IMeasurement<ILengthUnit> right)
            => ConvertTo(Length.OfType<Meter>(left.ValueInMeters() + right.ValueInMeters()), left.Unit);

        public static Length Subtract(this IMeasurement<ILengthUnit> left, IMeasurement<ILengthUnit> right)
            => ConvertTo(Length.OfType<Meter>(left.ValueInMeters() - right.ValueInMeters()), left.Unit);

        #endregion

        #region Conversions

        public static Length ToLength<TUnit>(this double value) where TUnit : class, ILengthUnit
            => Length.OfType<TUnit>(value);

        public static Length ToLength(this double value, ILengthUnit unit)
            => new Length(value, unit);

        public static Length ToLength<TUnit>(this float value) where TUnit : class, ILengthUnit
            => Length.OfType<TUnit>(value);

        public static Length ToLength(this float value, ILengthUnit unit)
            => new Length(value, unit);

        public static Length ToLength<TUnit>(this decimal value) where TUnit : class, ILengthUnit
            => Length.OfType<TUnit>(value.ToDouble());

        public static Length ToLength(this decimal value, ILengthUnit unit)
            => new Length((double)value, unit);

        public static Length ToLength<TUnit>(this int value) where TUnit : class, ILengthUnit
            => Length.OfType<TUnit>(value);

        public static Length ToLength(this int value, ILengthUnit unit)
            => new Length(value, unit);

        public static Length ToLength<TUnit>(this long value) where TUnit : class, ILengthUnit
            => Length.OfType<TUnit>(value);

        public static Length ToLength(this long value, ILengthUnit unit)
            => new Length(value, unit);

        public static Length ToLength<T>(this T measurement) where T : IMeasurement<ILengthUnit>
            => measurement is Length length ? length : new Length(measurement);

        public static Length ConvertTo<TUnit>(this IMeasurement<ILengthUnit> length) where TUnit : class, ILengthUnit
            => length.ConvertTo(UnitRegistry.Get<TUnit>());

        public static Length ConvertTo<TPrefix, TUnit>(this IMeasurement<ILengthUnit> length) where TPrefix : IPrefix where TUnit : class, ILengthUnit
            => length.ConvertTo(UnitRegistry.Get<PrefixedLength<TPrefix, TUnit>>());

        public static Length ConvertTo(this IMeasurement<ILengthUnit> length, ILengthUnit targetUnit)
            => targetUnit.FromMeters(length.ValueInMeters()).ToLength(targetUnit);

        #endregion

        private static double ValueInMeters<T>(this T measurement) where T : IMeasurement<ILengthUnit>
            => measurement.Unit.ToMeters(measurement.Value);
    }
}
