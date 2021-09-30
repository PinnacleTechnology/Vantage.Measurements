//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Vantage.Measurements.Units;
//using Vantage.Measurements.Units.Acceleration;
//using Vantage.Measurements.Units.Length;
//using Vantage.Measurements.Units.Time;

//namespace Vantage.Measurements
//{
//    public static class AccelerationExtensions
//    {
//        #region Operators

//        public static bool IsEqualTo(this IMeasurement<IAccelerationUnit> left, IMeasurement<IAccelerationUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecondSquared().IsEqualTo(right.ValueInMetersPerSecondSquared(), precision);

//        public static bool IsNotEqualTo(this IMeasurement<IAccelerationUnit> left, IMeasurement<IAccelerationUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecondSquared().IsNotEqualTo(right.ValueInMetersPerSecondSquared(), precision);

//        public static bool IsGreaterThan(this IMeasurement<IAccelerationUnit> left, IMeasurement<IAccelerationUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecondSquared().IsGreaterThan(right.ValueInMetersPerSecondSquared(), precision);

//        public static bool IsGreaterThanOrEqualTo(this IMeasurement<IAccelerationUnit> left, IMeasurement<IAccelerationUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecondSquared().IsGreaterThanOrEqualTo(right.ValueInMetersPerSecondSquared(), precision);

//        public static bool IsLessThan(this IMeasurement<IAccelerationUnit> left, IMeasurement<IAccelerationUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecondSquared().IsLessThan(right.ValueInMetersPerSecondSquared(), precision);

//        public static bool IsLessThanOrEqualTo(this IMeasurement<IAccelerationUnit> left, IMeasurement<IAccelerationUnit> right, double precision = Precision.Default)
//            => left.ValueInMetersPerSecondSquared().IsLessThanOrEqualTo(right.ValueInMetersPerSecondSquared(), precision);

//        public static Acceleration Add(this IMeasurement<IAccelerationUnit> measurement, double scalar)
//            => new Acceleration(measurement.Value + scalar, measurement.Unit);

//        public static Acceleration Subtract(this IMeasurement<IAccelerationUnit> measurement, double scalar)
//            => new Acceleration(measurement.Value - scalar, measurement.Unit);

//        public static Acceleration MultiplyBy(this IMeasurement<IAccelerationUnit> measurement, double scalar)
//            => new Acceleration(measurement.Value * scalar, measurement.Unit);

//        public static Acceleration DivideBy(this IMeasurement<IAccelerationUnit> measurement, double scalar)
//            => new Acceleration(measurement.Value / scalar, measurement.Unit);

//        public static Acceleration Add(this IMeasurement<IAccelerationUnit> left, IMeasurement<IAccelerationUnit> right)
//            => Acceleration.DerivedFrom<Meter, Second>(left.ValueInMetersPerSecondSquared() + right.ValueInMetersPerSecondSquared()).To(left.Unit);

//        public static Acceleration Subtract(this IMeasurement<IAccelerationUnit> left, IMeasurement<IAccelerationUnit> right)
//            => Acceleration.DerivedFrom<Meter, Second>(left.ValueInMetersPerSecondSquared() - right.ValueInMetersPerSecondSquared()).To(left.Unit);

//        #endregion


//        #region Conversions

//        public static Acceleration As<TUnit>(this double value) where TUnit : IAccelerationUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static Acceleration As(this double value, IAccelerationUnit unit)
//            => new Acceleration(value, unit);

//        public static Acceleration As<TUnit>(this float value) where TUnit : IAccelerationUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static Acceleration As(this float value, IAccelerationUnit unit)
//            => new Acceleration(value, unit);

//        public static Acceleration As<TUnit>(this decimal value) where TUnit : IAccelerationUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static Acceleration As(this decimal value, IAccelerationUnit unit)
//            => new Acceleration((double)value, unit);

//        public static Acceleration As<TUnit>(this int value) where TUnit : IAccelerationUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static Acceleration As(this int value, IAccelerationUnit unit)
//            => new Acceleration(value, unit);

//        public static Acceleration As<TUnit>(this long value) where TUnit : IAccelerationUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static Acceleration As(this long value, IAccelerationUnit unit)
//            => new Acceleration(value, unit);

//        public static Acceleration AsAcceleration<T>(this T measurement) where T : IMeasurement<IAccelerationUnit>
//            => measurement is Acceleration acceleration ? acceleration : measurement.CreateAcceleration();

//        public static Acceleration To<TUnit>(this IMeasurement<IAccelerationUnit> acceleration) where TUnit : IAccelerationUnit
//            => acceleration.To(UnitRegistry.GetUnit<TUnit>());

//        public static Acceleration To(this IMeasurement<IAccelerationUnit> acceleration, IAccelerationUnit targetUnit)
//            => targetUnit.FromMetersPerSecondSquared(acceleration.ValueInMetersPerSecondSquared()).As(targetUnit);

//        #endregion


//        #region Lists

//        public static AccelerationList ToAccelerationList<T>(this IEnumerable<T> source, IAccelerationUnit targetUnit) where T : IMeasurement<IAccelerationUnit>
//            => new AccelerationList(source.Select(AsAcceleration), targetUnit);

//        public static Acceleration Sum<T>(this IEnumerable<T> source) where T : IMeasurement<IAccelerationUnit>
//            => source.Sum(ValueInMetersPerSecondSquared).As<CompositeAcceleration<Meter, Second>>();

//        public static Acceleration Max<T>(this IEnumerable<T> source) where T : IMeasurement<IAccelerationUnit>
//            => source.Max(ValueInMetersPerSecondSquared).As<CompositeAcceleration<Meter, Second>>();

//        public static Acceleration Min<T>(this IEnumerable<T> source) where T : IMeasurement<IAccelerationUnit>
//            => source.Min(ValueInMetersPerSecondSquared).As<CompositeAcceleration<Meter, Second>>();

//        public static Acceleration Average<T>(this IEnumerable<T> source) where T : IMeasurement<IAccelerationUnit>
//            => source.Average(ValueInMetersPerSecondSquared).As<CompositeAcceleration<Meter, Second>>();

//        #endregion

//        private static double ValueInMetersPerSecondSquared<T>(this T measurement) where T : IMeasurement<IAccelerationUnit>
//            => measurement.Unit.ToMetersPerSecondSquared(measurement.Value);

//        private static Acceleration CreateAcceleration(this IMeasurement<IAccelerationUnit> measurement)
//            => measurement != null ? new Acceleration(measurement.Value, measurement.Unit) : throw new ArgumentNullException(nameof(measurement));
//    }
//}