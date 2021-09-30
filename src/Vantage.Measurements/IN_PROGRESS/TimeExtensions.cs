//using System;

//using Vantage.Measurements.Units.Time;

//namespace Vantage.Measurements
//{
//    public static class TimeExtensions
//    {
//        #region Operators

//        public static bool IsZero(this IMeasurement<ITimeUnit> left, double precision = Precision.Default)
//            => left.ValueInSeconds().IsZero(precision);

//        public static bool IsEqualTo(this IMeasurement<ITimeUnit> left, IMeasurement<ITimeUnit> right, double precision = Precision.Default)
//            => left.ValueInSeconds().IsEqualTo(right.ValueInSeconds(), precision);

//        public static bool IsNotEqualTo(this IMeasurement<ITimeUnit> left, IMeasurement<ITimeUnit> right, double precision = Precision.Default)
//            => left.ValueInSeconds().IsNotEqualTo(right.ValueInSeconds(), precision);

//        public static bool IsGreaterThan(this IMeasurement<ITimeUnit> left, IMeasurement<ITimeUnit> right, double precision = Precision.Default)
//            => left.ValueInSeconds().IsGreaterThan(right.ValueInSeconds(), precision);

//        public static bool IsGreaterThanOrEqualTo(this IMeasurement<ITimeUnit> left, IMeasurement<ITimeUnit> right, double precision = Precision.Default)
//            => left.ValueInSeconds().IsGreaterThanOrEqualTo(right.ValueInSeconds(), precision);

//        public static bool IsLessThan(this IMeasurement<ITimeUnit> left, IMeasurement<ITimeUnit> right, double precision = Precision.Default)
//            => left.ValueInSeconds().IsLessThan(right.ValueInSeconds(), precision);

//        public static bool IsLessThanOrEqualTo(this IMeasurement<ITimeUnit> left, IMeasurement<ITimeUnit> right, double precision = Precision.Default)
//            => left.ValueInSeconds().IsLessThanOrEqualTo(right.ValueInSeconds(), precision);

//        public static Time Add(this IMeasurement<ITimeUnit> measurement, double scalar)
//            => new Time(measurement.Value + scalar, measurement.Unit);

//        public static Time Subtract(this IMeasurement<ITimeUnit> measurement, double scalar)
//            => new Time(measurement.Value - scalar, measurement.Unit);

//        public static Time MultiplyBy(this IMeasurement<ITimeUnit> measurement, double scalar)
//            => new Time(measurement.Value * scalar, measurement.Unit);

//        public static Time DivideBy(this IMeasurement<ITimeUnit> measurement, double scalar)
//            => new Time(measurement.Value / scalar, measurement.Unit);

//        public static Time Add(this IMeasurement<ITimeUnit> left, IMeasurement<ITimeUnit> right)
//            => Time.Of<Second>(left.ValueInSeconds() + right.ValueInSeconds()).To(left.Unit);

//        public static Time Subtract(this IMeasurement<ITimeUnit> left, IMeasurement<ITimeUnit> right)
//            => Time.Of<Second>(left.ValueInSeconds() - right.ValueInSeconds()).To(left.Unit);

//        #endregion


//        #region Conversions

//        public static Time ToTime<TUnit>(this double value) where TUnit : ITimeUnit
//            => value.ToTime(UnitRegistry.GetUnit<TUnit>());

//        public static Time ToTime<TUnit>(this double value, TUnit unit) where TUnit : ITimeUnit
//            => new Time(value, unit);

//        public static Time ToTime<TUnit>(this float value) where TUnit : ITimeUnit
//            => value.ToTime(UnitRegistry.GetUnit<TUnit>());

//        public static Time ToTime<TUnit>(this float value, TUnit unit) where TUnit : ITimeUnit
//            => new Time(value, unit);

//        public static Time ToTime<TUnit>(this decimal value) where TUnit : ITimeUnit
//            => value.ToTime(UnitRegistry.GetUnit<TUnit>());

//        public static Time ToTime<TUnit>(this decimal value, TUnit unit) where TUnit : ITimeUnit
//            => new Time((double)value, unit);

//        public static Time ToTime<TUnit>(this int value) where TUnit : ITimeUnit
//            => value.ToTime(UnitRegistry.GetUnit<TUnit>());

//        public static Time ToTime<TUnit>(this int value, TUnit unit) where TUnit : ITimeUnit
//            => new Time(value, unit);

//        public static Time ToTime<TUnit>(this long value) where TUnit : ITimeUnit
//            => value.ToTime(UnitRegistry.GetUnit<TUnit>());

//        public static Time ToTime<TUnit>(this long value, TUnit unit) where TUnit : ITimeUnit
//            => new Time(value, unit);

//        public static Time AsTime<T>(this T measurement) where T : IMeasurement<ITimeUnit>
//            => measurement is Time time ? time : measurement.CreateTime();

//        public static Time To<TUnit>(this IMeasurement<ITimeUnit> length) where TUnit : ITimeUnit
//            => length.To(UnitRegistry.GetUnit<TUnit>());

//        public static Time To<TUnit>(this IMeasurement<ITimeUnit> length, TUnit targetUnit) where TUnit : ITimeUnit
//            => targetUnit.FromSeconds(length.ValueInSeconds()).ToTime(targetUnit);

//        #endregion



//        private static double ValueInSeconds<T>(this T measurement) where T : IMeasurement<ITimeUnit> => measurement.Unit.ToSeconds(measurement.Value);

//        private static Time CreateTime(this IMeasurement<ITimeUnit> measurement)
//            => measurement != null ? new Time(measurement.Value, measurement.Unit) : throw new ArgumentNullException(nameof(measurement));
//    }
//}
