using System;
using Vantage.Measurements;
using Vantage.Measurements.Registration;
using Vantage.Measurements.Units;
using Vantage.Measurements.Units.Angle;
using Vantage.Numerics;

namespace Vantage.Measurements
{
    public static partial class Extensions
    {
        #region Trig

        public static Angle Atan<T>(this double value) where T : class, IAngleUnit
            => Math.Atan(value).ToAngle<T>();

        public static Angle Atan(this double value, IAngleUnit unit)
            => Math.Atan(value).ToAngle(unit);

        public static Angle Sin<T>(this double value) where T : class, IAngleUnit
            => Math.Asin(value).ToAngle<T>();

        public static Angle Sin(this double value, IAngleUnit unit)
            => Math.Asin(value).ToAngle(unit);

        public static Angle Acos<T>(this double value) where T : class, IAngleUnit
            => Math.Acos(value).ToAngle<T>();

        public static Angle Acos(this double value, IAngleUnit unit)
            => Math.Acos(value).ToAngle(unit);

        public static Angle Atanh<T>(this double value) where T : class, IAngleUnit
            => Math.Atanh(value).ToAngle<T>();

        public static Angle Atanh(this double value, IAngleUnit unit)
            => Math.Atanh(value).ToAngle(unit);

        public static Angle Sinh<T>(this double value) where T : class, IAngleUnit
            => Math.Sinh(value).ToAngle<T>();

        public static Angle Sinh(this double value, IAngleUnit unit)
            => Math.Sinh(value).ToAngle(unit);

        public static Angle Acosh<T>(this double value) where T : class, IAngleUnit
            => Math.Acosh(value).ToAngle<T>();

        public static Angle Acosh(this double value, IAngleUnit unit)
            => Math.Acosh(value).ToAngle(unit);

        public static double Tan(this IMeasurement<IAngleUnit> angle)
            => Math.Tan(angle.ValueInRadians());

        public static double Sin(this IMeasurement<IAngleUnit> angle)
            => Math.Sin(angle.ValueInRadians());

        public static double Cos(this IMeasurement<IAngleUnit> angle)
            => Math.Cos(angle.ValueInRadians());

        public static double Tanh(this IMeasurement<IAngleUnit> angle)
            => Math.Tanh(angle.ValueInRadians());

        public static double Sinh(this IMeasurement<IAngleUnit> angle)
            => Math.Sinh(angle.ValueInRadians());

        public static double Cosh(this IMeasurement<IAngleUnit> angle)
            => Math.Cosh(angle.ValueInRadians());

        #endregion

        #region Operators

        public static bool IsEqualTo(this IMeasurement<IAngleUnit> left, IMeasurement<IAngleUnit> right, double precision = Precision.Default)
            => left.ValueInRadians().IsEqualTo(right.ValueInRadians(), precision);

        public static bool IsNotEqualTo(this IMeasurement<IAngleUnit> left, IMeasurement<IAngleUnit> right, double precision = Precision.Default)
            => left.ValueInRadians().IsNotEqualTo(right.ValueInRadians(), precision);

        public static bool IsGreaterThan(this IMeasurement<IAngleUnit> left, IMeasurement<IAngleUnit> right, double precision = Precision.Default)
            => left.ValueInRadians().IsGreaterThan(right.ValueInRadians(), precision);

        public static bool IsGreaterThanOrEqualTo(this IMeasurement<IAngleUnit> left, IMeasurement<IAngleUnit> right, double precision = Precision.Default)
            => left.ValueInRadians().IsGreaterThanOrEqualTo(right.ValueInRadians(), precision);

        public static bool IsLessThan(this IMeasurement<IAngleUnit> left, IMeasurement<IAngleUnit> right, double precision = Precision.Default)
            => left.ValueInRadians().IsLessThan(right.ValueInRadians(), precision);

        public static bool IsLessThanOrEqualTo(this IMeasurement<IAngleUnit> left, IMeasurement<IAngleUnit> right, double precision = Precision.Default)
            => left.ValueInRadians().IsLessThanOrEqualTo(right.ValueInRadians(), precision);

        public static Angle Offset(this IMeasurement<IAngleUnit> measurement, double scalar)
            => new Angle(measurement) + scalar;

        public static Angle Scale(this IMeasurement<IAngleUnit> measurement, double scalar)
            => new Angle(measurement) * scalar;

        public static Angle Add(this IMeasurement<IAngleUnit> left, IMeasurement<IAngleUnit> right)
            => ConvertTo(Angle.OfType<Radian>(left.ValueInRadians() + right.ValueInRadians()), left.Unit);

        public static Angle Subtract(this IMeasurement<IAngleUnit> left, IMeasurement<IAngleUnit> right)
            => ConvertTo(Angle.OfType<Radian>(left.ValueInRadians() - right.ValueInRadians()), left.Unit);

        #endregion

        #region Conversions

        public static Angle ToAngle<TUnit>(this double value) where TUnit : class, IAngleUnit
            => Angle.OfType<TUnit>(value);

        public static Angle ToAngle(this double value, IAngleUnit unit)
            => new Angle(value, unit);

        public static Angle ToAngle<TUnit>(this float value) where TUnit : class, IAngleUnit
            => Angle.OfType<TUnit>(value);

        public static Angle ToAngle(this float value, IAngleUnit unit)
            => new Angle(value, unit);

        public static Angle ToAngle<TUnit>(this decimal value) where TUnit : class, IAngleUnit
            => Angle.OfType<TUnit>(value.ToDouble());

        public static Angle ToAngle(this decimal value, IAngleUnit unit)
            => new Angle((double)value, unit);

        public static Angle ToAngle<TUnit>(this int value) where TUnit : class, IAngleUnit
            => Angle.OfType<TUnit>(value);

        public static Angle ToAngle(this int value, IAngleUnit unit)
            => new Angle(value, unit);

        public static Angle ToAngle<TUnit>(this long value) where TUnit : class, IAngleUnit
            => Angle.OfType<TUnit>(value);

        public static Angle ToAngle(this long value, IAngleUnit unit)
            => new Angle(value, unit);

        public static Angle ToAngle<T>(this T measurement) where T : IMeasurement<IAngleUnit>
            => measurement is Angle length ? length : new Angle(measurement);

        public static Angle ConvertTo<TUnit>(this IMeasurement<IAngleUnit> length) where TUnit : class, IAngleUnit
            => length.ConvertTo(UnitRegistry.Get<TUnit>());

        public static Angle ConvertTo(this IMeasurement<IAngleUnit> length, IAngleUnit targetUnit)
            => targetUnit.FromRadians(length.ValueInRadians()).ToAngle(targetUnit);

        #endregion

        private static double ValueInRadians<T>(this T measurement) where T : IMeasurement<IAngleUnit>
            => measurement.Unit.ToRadians(measurement.Value);
    }
}