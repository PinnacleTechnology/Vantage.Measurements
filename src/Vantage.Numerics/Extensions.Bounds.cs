using System;
using System.Collections.Generic;
using System.Text;

namespace Vantage.Numerics
{
    public static partial class Extensions
    {

        #region IsBetween

        public static bool IsBetween(this double value, double bound1, double bound2)
        {
            return value.IsBetween(bound1, bound2, Precision.Current);
        }

        public static bool IsBetween(this double value, double bound1, double bound2, double precision)
        {
            var (lower, upper) = GetBounds(bound1, bound2);
            return value.IsGreaterThanOrEqualTo(lower, precision) && value.IsLessThanOrEqualTo(upper, precision);
        }

        public static bool IsBetween(this float value, float bound1, float bound2)
        {
            return value.IsBetween(bound1, bound2, (float)Precision.Current);
        }

        public static bool IsBetween(this float value, float bound1, float bound2, float precision)
        {
            var (lower, upper) = GetBounds(bound1, bound2);
            return value.IsGreaterThanOrEqualTo(lower, precision) && value.IsLessThanOrEqualTo(upper, precision);
        }

        public static bool IsBetween(this decimal value, decimal bound1, decimal bound2)
        {
            return value.IsBetween(bound1, bound2, (decimal)Precision.Current);
        }

        public static bool IsBetween(this decimal value, decimal bound1, decimal bound2, decimal precision)
        {
            var (lower, upper) = GetBounds(bound1, bound2);
            return value.IsGreaterThanOrEqualTo(lower, precision) && value.IsLessThanOrEqualTo(upper, precision);
        }

        public static bool IsBetween(this long value, long bound1, long bound2)
        {
            var (lower, upper) = GetBounds(bound1, bound2);
            return value.IsGreaterThanOrEqualTo(lower) && value.IsLessThanOrEqualTo(upper);
        }

        public static bool IsBetween(this int value, int bound1, int bound2)
        {
            var (lower, upper) = GetBounds(bound1, bound2);
            return value.IsGreaterThanOrEqualTo(lower) && value.IsLessThanOrEqualTo(upper);
        }

        #endregion

        #region IsStrictlyBetween

        public static bool IsStrictlyBetween(this double value, double bound1, double bound2)
        {
            return value.IsStrictlyBetween(bound1, bound2, Precision.Current);
        }

        public static bool IsStrictlyBetween(this double value, double bound1, double bound2, double precision)
        {
            var (lower, upper) = GetBounds(bound1, bound2);
            return value.IsGreaterThan(lower, precision) && value.IsLessThan(upper, precision);
        }

        public static bool IsStrictlyBetween(this float value, float bound1, float bound2)
        {
            return value.IsStrictlyBetween(bound1, bound2, (float)Precision.Current);
        }

        public static bool IsStrictlyBetween(this float value, float bound1, float bound2, float precision)
        {
            var (lower, upper) = GetBounds(bound1, bound2);
            return value.IsGreaterThan(lower, precision) && value.IsLessThan(upper, precision);
        }

        public static bool IsStrictlyBetween(this decimal value, decimal bound1, decimal bound2)
        {
            return value.IsStrictlyBetween(bound1, bound2, (decimal)Precision.Current);
        }

        public static bool IsStrictlyBetween(this decimal value, decimal bound1, decimal bound2, decimal precision)
        {
            var (lower, upper) = GetBounds(bound1, bound2);
            return value.IsGreaterThan(lower, precision) && value.IsLessThan(upper, precision);
        }

        public static bool IsStrictlyBetween(this long value, long bound1, long bound2)
        {
            var (lower, upper) = GetBounds(bound1, bound2);
            return value.IsGreaterThan(lower) && value.IsLessThan(upper);
        }

        public static bool IsStrictlyBetween(this int value, int bound1, int bound2)
        {
            var (lower, upper) = GetBounds(bound1, bound2);
            return value.IsGreaterThan(lower) && value.IsLessThan(upper);
        }

        #endregion

        #region Clamp

        /// <inheritdoc cref="Math.Clamp(double, double, double)"/>
        public static double Clamp(this double value, double min, double max)
        {
            var (lower, upper) = GetBounds(min, max);
            return Math.Clamp(value, lower, upper);
        }

        /// <inheritdoc cref="Math.Clamp(float, float, float)"/>
        public static float Clamp(this float value, float min, float max)
        {
            var (lower, upper) = GetBounds(min, max);
            return Math.Clamp(value, lower, upper);
        }

        /// <inheritdoc cref="Math.Clamp(decimal, decimal, decimal)"/>
        public static decimal Clamp(this decimal value, decimal min, decimal max)
        {
            var (lower, upper) = GetBounds(min, max);
            return Math.Clamp(value, lower, upper);
        }

        /// <inheritdoc cref="Math.Clamp(int, int, int)"/>
        public static int Clamp(this int value, int min, int max)
        {
            var (lower, upper) = GetBounds(min, max);
            return Math.Clamp(value, lower, upper);
        }

        /// <inheritdoc cref="Math.Clamp(long, long, long)"/>
        public static long Clamp(this long value, long min, long max)
        {
            var (lower, upper) = GetBounds(min, max);
            return Math.Clamp(value, lower, upper);
        }

        #endregion

        private static (double lower, double upper) GetBounds(double value1, double value2)
            => (Math.Min(value1, value2), Math.Max(value1, value2));

        private static (float lower, float upper) GetBounds(float value1, float value2)
            => (Math.Min(value1, value2), Math.Max(value1, value2));

        private static (decimal lower, decimal upper) GetBounds(decimal value1, decimal value2)
            => (Math.Min(value1, value2), Math.Max(value1, value2));

        private static (int lower, int upper) GetBounds(int value1, int value2)
            => (Math.Min(value1, value2), Math.Max(value1, value2));

        private static (long lower, long upper) GetBounds(long value1, long value2)
            => (Math.Min(value1, value2), Math.Max(value1, value2));
    }
}
