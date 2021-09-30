using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Vantage.Numerics
{
    public static partial class Extensions
    {
        #region IsZero

        public static bool IsZero(this double value)
            => value.IsZero(Precision.Current);

        public static bool IsZero(this double value, double precision)
            => value.IsEqualTo(0, precision);

        public static bool IsZero(this float value)
            => value.IsZero((float)Precision.Current);

        public static bool IsZero(this float value, float precision)
            => value.IsEqualTo(0, precision);

        public static bool IsZero(this decimal value)
            => value.IsZero((decimal)Precision.Current);

        public static bool IsZero(this decimal value, decimal precision)
            => value.IsEqualTo(0, precision);

        public static bool IsZero(this int value)
            => value == 0;

        public static bool IsZero(this long value)
            => value == 0;

        #endregion

        #region IsInfinity

        public static bool IsInfinity(this double value)
            => double.IsInfinity(value);

        public static bool IsInfinity(this float value)
            => float.IsInfinity(value);

        #endregion

        #region IsInfinity

        public static bool IsNegativeInfinity(this double value)
            => double.IsNegativeInfinity(value);

        public static bool IsNegativeInfinity(this float value)
            => float.IsNegativeInfinity(value);

        #endregion

        #region IsPositiveInfinity

        public static bool IsPositiveInfinity(this double value)
            => double.IsPositiveInfinity(value);

        public static bool IsPositiveInfinity(this float value)
            => float.IsPositiveInfinity(value);

        #endregion

        #region IsNaN

        public static bool IsNaN(this double value)
            => double.IsNaN(value);

        public static bool IsNaN(this float value)
            => float.IsNaN(value);

        #endregion

        #region IsFinite

        public static bool IsFinite(this double value)
            => double.IsFinite(value);

        public static bool IsFinite(this float value)
            => float.IsFinite(value);

        #endregion

        #region IsNormal

        public static bool IsNormal(this double value)
            => double.IsNormal(value);

        public static bool IsNormal(this float value)
            => float.IsNormal(value);

        #endregion

        #region IsSubnormal

        public static bool IsSubnormal(this double value)
            => double.IsSubnormal(value);

        public static bool IsSubnormal(this float value)
            => float.IsSubnormal(value);

        #endregion

        #region IsEqualTo

        public static bool IsEqualTo(this double left, double right)
            => left.IsEqualTo(right, Precision.Current);

        public static bool IsEqualTo(this double left, double right, double precision)
            => Math.Abs(left - right) <= precision;

        public static bool IsEqualTo(this float left, float right)
            => left.IsEqualTo(right, (float)Precision.Current);

        public static bool IsEqualTo(this float left, float right, float precision)
            => Math.Abs(left - right) <= precision;

        public static bool IsEqualTo(this decimal left, decimal right)
            => left.IsEqualTo(right, (decimal)Precision.Current);

        public static bool IsEqualTo(this decimal left, decimal right, decimal precision)
            => Math.Abs(left - right) <= precision;

        public static bool IsEqualTo(this int left, int right)
            => left == right;

        public static bool IsEqualTo(this long left, long right)
            => left == right;

        #endregion

        #region IsNotEqualTo

        public static bool IsNotEqualTo(this double left, double right)
            => left.IsNotEqualTo(right, Precision.Current);

        public static bool IsNotEqualTo(this double left, double right, double precision)
            => !left.IsEqualTo(right, precision);

        public static bool IsNotEqualTo(this float left, float right)
            => left.IsNotEqualTo(right, (float)Precision.Current);

        public static bool IsNotEqualTo(this float left, float right, float precision)
            => !left.IsEqualTo(right, precision);

        public static bool IsNotEqualTo(this decimal left, decimal right)
            => left.IsNotEqualTo(right, (decimal)Precision.Current);

        public static bool IsNotEqualTo(this decimal left, decimal right, decimal precision)
            => !left.IsEqualTo(right, precision);

        public static bool IsNotEqualTo(this int left, int right)
            => left != right;

        public static bool IsNotEqualTo(this long left, long right)
            => left != right;

        #endregion

        #region IsGreaterThan

        public static bool IsGreaterThan(this double left, double right)
            => left.IsGreaterThan(right, Precision.Current);

        public static bool IsGreaterThan(this double left, double right, double precision)
            => (left - right) > precision;

        public static bool IsGreaterThan(this float left, float right)
            => left.IsGreaterThan(right, (float)Precision.Current);

        public static bool IsGreaterThan(this float left, float right, float precision)
            => (left - right) > precision;

        public static bool IsGreaterThan(this decimal left, decimal right)
            => left.IsGreaterThan(right, (decimal)Precision.Current);

        public static bool IsGreaterThan(this decimal left, decimal right, decimal precision)
            => (left - right) > precision;

        public static bool IsGreaterThan(this int left, int right)
            => left > right;

        public static bool IsGreaterThan(this long left, long right)
            => left > right;

        #endregion

        #region IsGreaterThanOrEqualTo

        public static bool IsGreaterThanOrEqualTo(this double left, double right)
            => left.IsGreaterThanOrEqualTo(right, Precision.Current);

        public static bool IsGreaterThanOrEqualTo(this double left, double right, double precision)
            => (left - right) >= -precision;

        public static bool IsGreaterThanOrEqualTo(this float left, float right)
            => left.IsGreaterThanOrEqualTo(right, (float)Precision.Current);

        public static bool IsGreaterThanOrEqualTo(this float left, float right, float precision)
            => (left - right) >= -precision;

        public static bool IsGreaterThanOrEqualTo(this decimal left, decimal right)
            => left.IsGreaterThanOrEqualTo(right, (decimal)Precision.Current);

        public static bool IsGreaterThanOrEqualTo(this decimal left, decimal right, decimal precision)
            => (left - right) >= -precision;

        public static bool IsGreaterThanOrEqualTo(this int left, int right)
            => left >= right;

        public static bool IsGreaterThanOrEqualTo(this long left, long right)
            => left >= right;

        #endregion

        #region IsLessThan

        public static bool IsLessThan(this double left, double right)
            => left.IsLessThan(right, Precision.Current);

        public static bool IsLessThan(this double left, double right, double precision)
            => (left - right) < -precision;

        public static bool IsLessThan(this float left, float right)
            => left.IsLessThan(right, (float)Precision.Current);

        public static bool IsLessThan(this float left, float right, float precision)
            => (left - right) < -precision;

        public static bool IsLessThan(this decimal left, decimal right)
            => left.IsLessThan(right, (decimal)Precision.Current);

        public static bool IsLessThan(this decimal left, decimal right, decimal precision)
            => (left - right) < -precision;

        public static bool IsLessThan(this int left, int right)
            => left < right;

        public static bool IsLessThan(this long left, long right)
            => left < right;

        #endregion

        #region IsLessThanOrEqualTo

        public static bool IsLessThanOrEqualTo(this double left, double right)
            => left.IsLessThanOrEqualTo(right, Precision.Current);

        public static bool IsLessThanOrEqualTo(this double left, double right, double precision)
            => (left - right) < precision;

        public static bool IsLessThanOrEqualTo(this float left, float right)
            => left.IsLessThanOrEqualTo(right, (float)Precision.Current);

        public static bool IsLessThanOrEqualTo(this float left, float right, float precision)
            => (left - right) < precision;

        public static bool IsLessThanOrEqualTo(this decimal left, decimal right)
            => left.IsLessThanOrEqualTo(right, (decimal)Precision.Current);

        public static bool IsLessThanOrEqualTo(this decimal left, decimal right, decimal precision)
            => (left - right) < precision;

        public static bool IsLessThanOrEqualTo(this int left, int right)
            => left <= right;

        public static bool IsLessThanOrEqualTo(this long left, long right)
            => left <= right;

        #endregion


    }
}
