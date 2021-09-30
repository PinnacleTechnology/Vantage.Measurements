using System;

namespace Vantage.Numerics
{
    public static partial class Extensions
    {
        #region ToDouble

        /// <inheritdoc cref="Convert.ToDouble(float)"/>
        public static double ToDouble(this float value)
            => Convert.ToDouble(value);

        /// <inheritdoc cref="decimal.ToDouble(decimal)"/>
        public static double ToDouble(this decimal value)
            => decimal.ToDouble(value);

        /// <inheritdoc cref="Convert.ToDouble(int)"/>
        public static double ToDouble(this int value)
            => Convert.ToDouble(value);

        /// <inheritdoc cref="Convert.ToDouble(long)"/>
        public static double ToDouble(this long value)
            => Convert.ToDouble(value);

        #endregion

        #region ToSingle

        /// <inheritdoc cref="Convert.ToSingle(double)"/>
        public static float ToSingle(this double value)
            => Convert.ToSingle(value);

        /// <inheritdoc cref="decimal.ToSingle(decimal)"/>
        public static float ToSingle(this decimal value)
            => decimal.ToSingle(value);

        /// <inheritdoc cref="Convert.ToSingle(int)"/>
        public static float ToSingle(this int value)
            => Convert.ToSingle(value);

        /// <inheritdoc cref="Convert.ToSingle(long)"/>
        public static float ToSingle(this long value)
            => Convert.ToSingle(value);

        #endregion

        #region ToDecimal

        /// <inheritdoc cref="Convert.ToDecimal(double)"/>
        public static decimal ToDecimal(this double value)
            => Convert.ToDecimal(value);

        /// <inheritdoc cref="Convert.ToDecimal(float)"/>
        public static decimal ToDecimal(this float value)
            => Convert.ToDecimal(value);

        /// <inheritdoc cref="Convert.ToDecimal(int)"/>
        public static decimal ToDecimal(this int value)
            => Convert.ToDecimal(value);

        /// <inheritdoc cref="Convert.ToDecimal(long)"/>
        public static decimal ToDecimal(this long value)
            => Convert.ToDecimal(value);

        #endregion

        #region ToInt64

        /// <inheritdoc cref="Convert.ToInt64(double)"/>
        public static long ToInt64(this double value)
            => Convert.ToInt64(value);

        /// <inheritdoc cref="Convert.ToInt64(float)"/>
        public static long ToInt64(this float value)
            => Convert.ToInt64(value);

        /// <inheritdoc cref="decimal.ToInt64(decimal)"/>
        public static long ToInt64(this decimal value)
            => decimal.ToInt64(value);

        /// <inheritdoc cref="Convert.ToInt64(int)"/>
        public static long ToInt64(this int value)
            => Convert.ToInt64(value);

        #endregion

        #region ToInt32

        /// <inheritdoc cref="Convert.ToInt32(double)"/>
        public static int ToInt32(this double value)
            => Convert.ToInt32(value);

        /// <inheritdoc cref="Convert.ToInt32(float)"/>
        public static int ToInt32(this float value)
            => Convert.ToInt32(value);

        /// <inheritdoc cref="decimal.ToInt32(decimal)"/>
        public static int ToInt32(this decimal value)
            => decimal.ToInt32(value);

        /// <inheritdoc cref="Convert.ToInt32(long)"/>
        public static int ToInt32(this long value)
            => Convert.ToInt32(value);

        #endregion
    }
}
