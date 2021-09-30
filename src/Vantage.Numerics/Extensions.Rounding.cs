using System;
using System.Collections.Generic;
using System.Text;

namespace Vantage.Numerics
{
    public static partial class Extensions
    {
        #region Round

        /// <inheritdoc cref="Math.Round(double, MidpointRounding)"/>
        public static double Round(this double value, MidpointRounding mode = MidpointRounding.AwayFromZero)
            => Math.Round(value, mode);

        /// <inheritdoc cref="Math.Round(double, int, MidpointRounding)"/>
        public static double Round(this double value, int decimals, MidpointRounding mode = MidpointRounding.AwayFromZero)
            => Math.Round(value, decimals, mode);

        /// <inheritdoc cref="MathF.Round(float, MidpointRounding)"/>
        public static float Round(this float value, MidpointRounding mode = MidpointRounding.AwayFromZero)
            => MathF.Round(value, mode);

        /// <inheritdoc cref="MathF.Round(float, int, MidpointRounding)"/>
        public static float Round(this float value, int decimals, MidpointRounding mode = MidpointRounding.AwayFromZero)
            => MathF.Round(value, decimals, mode);

        /// <inheritdoc cref="Math.Round(decimal, MidpointRounding)"/>
        public static decimal Round(this decimal value, MidpointRounding mode = MidpointRounding.AwayFromZero)
            => decimal.Round(value, mode);

        /// <inheritdoc cref="Math.Round(decimal, int, MidpointRounding)"/>
        public static decimal Round(this decimal value, int decimals, MidpointRounding mode = MidpointRounding.AwayFromZero)
            => decimal.Round(value, decimals, mode);

        #endregion

        #region RoundToNearest

        public static double RoundToNearest(this double value, double precision)
            => (value / precision).Round() * precision;

        public static float RoundToNearest(this float value, float precision)
            => (value / precision).Round() * precision;

        public static decimal RoundToNearest(this decimal value, decimal precision)
            => (value / precision).Round() * precision;

        #endregion

        #region Floor

        /// <inheritdoc cref="Math.Floor(double)"/>
        public static double Floor(this double value)
            => Math.Floor(value);

        /// <inheritdoc cref="MathF.Floor(float)"/>
        public static float Floor(this float value)
            => MathF.Floor(value);

        /// <inheritdoc cref="decimal.Floor"/>
        public static decimal Floor(this decimal value)
            => decimal.Floor(value);

        #endregion

        #region Ceiling

        /// <inheritdoc cref="Math.Ceiling(double)"/>
        public static double Ceiling(this double value)
            => Math.Ceiling(value);

        /// <inheritdoc cref="MathF.Ceiling(float)"/>
        public static float Ceiling(this float value)
            => MathF.Ceiling(value);

        /// <inheritdoc cref="decimal.Ceiling"/>
        public static decimal Ceiling(this decimal value)
            => decimal.Ceiling(value);

        #endregion

        #region Truncate

        /// <inheritdoc cref="Math.Ceiling(double)"/>
        public static double Truncate(this double value)
            => Math.Truncate(value);

        /// <inheritdoc cref="MathF.Ceiling(float)"/>
        public static float Truncate(this float value)
            => MathF.Truncate(value);

        /// <inheritdoc cref="decimal.Truncate"/>
        public static decimal Truncate(this decimal value)
            => decimal.Truncate(value);

        #endregion
    }
}
