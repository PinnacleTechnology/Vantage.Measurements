
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Vantage.Numerics;

namespace Vantage.Measurements
{
    public static partial class Extensions
    {
        public static bool IsNaN(this IMeasurement measurement)
            => double.IsNaN(measurement.Value);

        public static bool IsInfinity(this IMeasurement measurement)
            => double.IsInfinity(measurement.Value);

        public static bool IsPositiveInfinity(this IMeasurement measurement)
            => double.IsPositiveInfinity(measurement.Value);

        public static bool IsNegativeInfinity(this IMeasurement measurement)
            => double.IsNegativeInfinity(measurement.Value);

        public static bool IsZero(this IMeasurement measurement, double precision = Precision.Default)
            => measurement.Value.IsZero(precision);

        public static bool IsEqualTo(this IMeasurement source, double targetValue, double precision = Precision.Default)
            => source.Value.IsEqualTo(targetValue, precision);

        public static bool IsNotEqualTo(this IMeasurement source, double targetValue, double precision = Precision.Default)
            => source.Value.IsNotEqualTo(targetValue, precision);

        public static bool IsGreaterThan(this IMeasurement source, double targetValue, double precision = Precision.Default)
            => source.Value.IsGreaterThan(targetValue, precision);

        public static bool IsGreaterThanOrEqualTo(this IMeasurement source, double targetValue, double precision = Precision.Default)
            => source.Value.IsGreaterThanOrEqualTo(targetValue, precision);

        public static bool IsLessThan(this IMeasurement source, double targetValue, double precision = Precision.Default)
            => source.Value.IsLessThan(targetValue, precision);

        public static bool IsLessThanOrEqualTo(this IMeasurement source, double targetValue, double precision = Precision.Default)
            => source.Value.IsLessThanOrEqualTo(targetValue, precision);

        public static double ToDouble(this IMeasurement measurement)
            => measurement.Value;

        public static float ToSingle(this IMeasurement measurement)
            => measurement.Value.ToSingle();

        public static decimal ToDecimal(this IMeasurement measurement)
            => measurement.Value.ToDecimal();

        public static int ToInt32(this IMeasurement measurement)
            => measurement.Value.ToInt32();

        public static long ToInt64(this IMeasurement measurement)
            => measurement.Value.ToInt64();

        public static bool IsNull(this IUnit? unit) 
            => unit is null;

        public static bool IsNotNull(this IUnit? unit) 
            => !unit.IsNull();
    }
}
