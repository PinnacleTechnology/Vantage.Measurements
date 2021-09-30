using System;
using System.Collections.Generic;
using System.Text;

namespace Vantage.Numerics
{
    public static partial class Extensions
    {
        #region Squared

        public static double Squared(this double value)
            => value * value;

        public static float Squared(this float value)
            => value * value;

        public static decimal Squared(this decimal value)
            => value * value;

        public static int Squared(this int value)
            => value * value;

        public static long Squared(this long value)
            => value * value;

        #endregion

        #region Cubed

        public static double Cubed(this double value)
            => value * value * value;

        public static float Cubed(this float value)
            => value * value * value;

        public static decimal Cubed(this decimal value)
            => value * value * value;

        public static int Cubed(this int value)
            => value * value * value;

        public static long Cubed(this long value)
            => value * value * value;

        #endregion

        #region SquareRoot

        /// <inheritdoc cref="Math.Sqrt"/>
        public static double SquareRoot(this double value)
            => Math.Sqrt(value);

        /// <inheritdoc cref="MathF.Sqrt"/>
        public static float SquareRoot(this float value)
            => MathF.Sqrt(value);

        /// <inheritdoc cref="Math.Sqrt"/>
        public static decimal SquareRoot(this decimal value)
            => Math.Sqrt((double)value).ToDecimal();

        /// <inheritdoc cref="Math.Sqrt"/>
        public static double SquareRoot(this int value)
            => Math.Sqrt(value);

        /// <inheritdoc cref="Math.Sqrt"/>
        public static double SquareRoot(this long value)
            => Math.Sqrt(value);

        #endregion

        #region Pow

        /// <inheritdoc cref="Math.Pow"/>
        public static double Pow(this double x, double y)
            => Math.Pow(x, y);

        /// <inheritdoc cref="Math.Pow"/>
        public static double Pow(this float x, double y)
            => Math.Pow(x, y);

        /// <inheritdoc cref="Math.Pow"/>
        public static double Pow(this decimal x, double y)
            => Math.Pow(x.ToDouble(), y);

        /// <inheritdoc cref="Math.Pow"/>
        public static double Pow(this int x, double y)
            => Math.Pow(x, y);

        /// <inheritdoc cref="Math.Pow"/>
        public static double Pow(this long x, double y)
            => Math.Pow(x, y);

        #endregion

        #region CubeRoot

        /// <inheritdoc cref="Math.Cbrt"/>
        public static double CubeRoot(this double value)
            => Math.Cbrt(value);

        /// <inheritdoc cref="MathF.Cbrt"/>
        public static float CubeRoot(this float value)
            => MathF.Cbrt(value);

        /// <inheritdoc cref="Math.Cbrt"/>
        public static decimal CubeRoot(this decimal value)
            => (decimal)Math.Cbrt((double)value);

        /// <inheritdoc cref="Math.Cbrt"/>
        public static double CubeRoot(this int value)
            => Math.Cbrt(value);

        /// <inheritdoc cref="Math.Cbrt"/>
        public static double CubeRoot(this long value)
            => Math.Cbrt(value);

        #endregion

        #region AbsoluteValue

        /// <inheritdoc cref="Math.Abs(double)"/>
        public static double AbsoluteValue(this double value)
            => Math.Abs(value);

        /// <inheritdoc cref="Math.Abs(float)"/>
        public static float AbsoluteValue(this float value)
            => Math.Abs(value);

        /// <inheritdoc cref="Math.Abs(decimal)"/>
        public static decimal AbsoluteValue(this decimal value)
            => Math.Abs(value);

        /// <inheritdoc cref="Math.Abs(int)"/>
        public static int AbsoluteValue(this int value)
            => Math.Abs(value);

        /// <inheritdoc cref="Math.Abs(long)"/>
        public static long AbsoluteValue(this long value)
            => Math.Abs(value);

        #endregion



        #region Sign

        /// <inheritdoc cref="Math.Sign(double)"/>
        public static int Sign(this double value)
            => Math.Sign(value);

        /// <inheritdoc cref="Math.Sign(float)"/>
        public static int Sign(this float value)
            => Math.Sign(value);

        /// <inheritdoc cref="Math.Sign(decimal)"/>
        public static int Sign(this decimal value)
            => Math.Sign(value);

        /// <inheritdoc cref="Math.Sign(int)"/>
        public static int Sign(this int value)
            => Math.Sign(value);

        /// <inheritdoc cref="Math.Sign(long)"/>
        public static int Sign(this long value)
            => Math.Sign(value);

        #endregion

        #region Max

        public static double Max(this double val1, double val2)
            => Math.Max(val1, val2);

        public static float Max(this float val1, float val2)
            => Math.Max(val1, val2);

        public static decimal Max(this decimal val1, decimal val2)
            => Math.Max(val1, val2);

        public static int Max(this int val1, int val2)
            => Math.Max(val1, val2);

        public static long Max(this long val1, long val2)
            => Math.Max(val1, val2);

        #endregion

        #region Min

        public static double Min(this double val1, double val2)
            => Math.Min(val1, val2);

        public static float Min(this float val1, float val2)
            => Math.Min(val1, val2);

        public static decimal Min(this decimal val1, decimal val2)
            => Math.Min(val1, val2);

        public static int Min(this int val1, int val2)
            => Math.Min(val1, val2);

        public static long Min(this long val1, long val2)
            => Math.Min(val1, val2);

        #endregion
    }
}
