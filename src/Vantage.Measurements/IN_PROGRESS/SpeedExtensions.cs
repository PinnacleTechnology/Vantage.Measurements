//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using Vantage.Measurements.Units.Speed;
//using Vantage.Measurements.Units.Length;
//using Vantage.Measurements.Units.Speed;
//using Vantage.Measurements.Units.Time;


//namespace Vantage.Measurements
//{
//    public static class SpeedExtensions
//    {
//        #region Operators

//        public static bool IsZero(this IMeasurement<ISpeedUnit> left, double precision = Precision.Default)
//            => left.ValueInMetersPerSecond().IsZero(precision);

//        public static bool IsEqualTo(this IMeasurement<ISpeedUnit> left, IMeasurement<ISpeedUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecond().IsEqualTo(right.ValueInMetersPerSecond(), precision);

//        public static bool IsNotEqualTo(this IMeasurement<ISpeedUnit> left, IMeasurement<ISpeedUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecond().IsNotEqualTo(right.ValueInMetersPerSecond(), precision);

//        public static bool IsGreaterThan(this IMeasurement<ISpeedUnit> left, IMeasurement<ISpeedUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecond().IsGreaterThan(right.ValueInMetersPerSecond(), precision);

//        public static bool IsGreaterThanOrEqualTo(this IMeasurement<ISpeedUnit> left, IMeasurement<ISpeedUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecond().IsGreaterThanOrEqualTo(right.ValueInMetersPerSecond(), precision);

//        public static bool IsLessThan(this IMeasurement<ISpeedUnit> left, IMeasurement<ISpeedUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecond().IsLessThan(right.ValueInMetersPerSecond(), precision);

//        public static bool IsLessThanOrEqualTo(this IMeasurement<ISpeedUnit> left, IMeasurement<ISpeedUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecond().IsLessThanOrEqualTo(right.ValueInMetersPerSecond(), precision);

//        public static Speed Add(this IMeasurement<ISpeedUnit> measurement, double scalar)
//            => new Speed(measurement.Value + scalar, measurement.Unit);

//        public static Speed Subtract(this IMeasurement<ISpeedUnit> measurement, double scalar)
//            => new Speed(measurement.Value - scalar, measurement.Unit);

//        public static Speed MultiplyBy(this IMeasurement<ISpeedUnit> measurement, double scalar)
//            => new Speed(measurement.Value * scalar, measurement.Unit);

//        public static Speed DivideBy(this IMeasurement<ISpeedUnit> measurement, double scalar)
//            => new Speed(measurement.Value / scalar, measurement.Unit);

//        public static Speed Add(this IMeasurement<ISpeedUnit> left, IMeasurement<ISpeedUnit> right)
//            => Speed.Of<CompositeSpeed<Meter, Second>>(left.ValueInMetersPerSecond() + right.ValueInMetersPerSecond()).To(left.Unit);

//        public static Speed Subtract(this IMeasurement<ISpeedUnit> left, IMeasurement<ISpeedUnit> right)
//            => Speed.Of<CompositeSpeed<Meter, Second>>(left.ValueInMetersPerSecond() - right.ValueInMetersPerSecond()).To(left.Unit);

//        #endregion


//        #region Conversions

//        public static Speed As<TUnit>(this double value) where TUnit : ISpeedUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static Speed As<TUnit>(this double value, TUnit unit) where TUnit : ISpeedUnit
//            => new Speed(value, unit);

//        public static Speed As<TUnit>(this float value) where TUnit : ISpeedUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static Speed As<TUnit>(this float value, TUnit unit) where TUnit : ISpeedUnit
//            => new Speed(value, unit);

//        public static Speed As<TUnit>(this decimal value) where TUnit : ISpeedUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static Speed As<TUnit>(this decimal value, TUnit unit) where TUnit : ISpeedUnit
//            => new Speed((double)value, unit);

//        public static Speed As<TUnit>(this int value) where TUnit : ISpeedUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static Speed As<TUnit>(this int value, TUnit unit) where TUnit : ISpeedUnit
//            => new Speed(value, unit);

//        public static Speed As<TUnit>(this long value) where TUnit : ISpeedUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static Speed As<TUnit>(this long value, TUnit unit) where TUnit : ISpeedUnit
//            => new Speed(value, unit);

//        public static Speed AsSpeed<T>(this T measurement) where T : IMeasurement<ISpeedUnit>
//            => measurement is Speed speed ? speed : measurement.CreateSpeed();

//        public static Speed To<TUnit>(this IMeasurement<ISpeedUnit> length) where TUnit : ISpeedUnit
//            => length.To(UnitRegistry.GetUnit<TUnit>());

//        public static Speed To<TUnit>(this IMeasurement<ISpeedUnit> length, TUnit targetUnit) where TUnit : ISpeedUnit
//            => targetUnit.FromMetersPerSecond(length.ValueInMetersPerSecond()).As(targetUnit);

//        #endregion


//        #region Lists

//        public static SpeedList ToSpeedList<T>(this IEnumerable<T> source, ISpeedUnit targetUnit) where T : IMeasurement<ISpeedUnit>
//            => new SpeedList(source.Select(AsSpeed), targetUnit);

//        public static Speed Sum<T>(this IEnumerable<T> source) where T : IMeasurement<ISpeedUnit>
//            => source.Sum(ValueInMetersPerSecond).As<CompositeSpeed<Meter, Second>>();

//        public static Speed Max<T>(this IEnumerable<T> source) where T : IMeasurement<ISpeedUnit>
//            => source.Max(ValueInMetersPerSecond).As<CompositeSpeed<Meter, Second>>();

//        public static Speed Min<T>(this IEnumerable<T> source) where T : IMeasurement<ISpeedUnit>
//            => source.Min(ValueInMetersPerSecond).As<CompositeSpeed<Meter, Second>>();

//        public static Speed Average<T>(this IEnumerable<T> source) where T : IMeasurement<ISpeedUnit>
//            => source.Average(ValueInMetersPerSecond).As<CompositeSpeed<Meter, Second>>();

//        #endregion


//        private static double ValueInMetersPerSecond<T>(this T measurement) where T : IMeasurement<ISpeedUnit>
//            => measurement.Unit.ToMetersPerSecond(measurement.Value);

//        private static Speed CreateSpeed(this IMeasurement<ISpeedUnit> measurement)
//            => measurement != null ? new Speed(measurement.Value, measurement.Unit) : throw new ArgumentNullException(nameof(measurement));
//    }
//}