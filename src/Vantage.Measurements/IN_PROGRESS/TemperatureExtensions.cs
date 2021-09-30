//using System;

//using Vantage.Measurements.Units.Temperature;

//namespace Vantage.Measurements
//{
//    public static class TemperatureExtensions
//    {
//        #region Operators

//        public static bool IsZero(this IMeasurement<ITemperatureUnit> left, double precision = Precision.Default)
//            => left.ValueInKelvin().IsZero(precision);

//        public static bool IsEqualTo(this IMeasurement<ITemperatureUnit> left, IMeasurement<ITemperatureUnit> right, double precision = Precision.Default)
//            => left.ValueInKelvin().IsEqualTo(right.ValueInKelvin(), precision);

//        public static bool IsNotEqualTo(this IMeasurement<ITemperatureUnit> left, IMeasurement<ITemperatureUnit> right, double precision = Precision.Default)
//            => left.ValueInKelvin().IsNotEqualTo(right.ValueInKelvin(), precision);

//        public static bool IsGreaterThan(this IMeasurement<ITemperatureUnit> left, IMeasurement<ITemperatureUnit> right, double precision = Precision.Default)
//            => left.ValueInKelvin().IsGreaterThan(right.ValueInKelvin(), precision);

//        public static bool IsGreaterThanOrEqualTo(this IMeasurement<ITemperatureUnit> left, IMeasurement<ITemperatureUnit> right, double precision = Precision.Default)
//            => left.ValueInKelvin().IsGreaterThanOrEqualTo(right.ValueInKelvin(), precision);

//        public static bool IsLessThan(this IMeasurement<ITemperatureUnit> left, IMeasurement<ITemperatureUnit> right, double precision = Precision.Default)
//            => left.ValueInKelvin().IsLessThan(right.ValueInKelvin(), precision);

//        public static bool IsLessThanOrEqualTo(this IMeasurement<ITemperatureUnit> left, IMeasurement<ITemperatureUnit> right, double precision = Precision.Default)
//            => left.ValueInKelvin().IsLessThanOrEqualTo(right.ValueInKelvin(), precision);

//        public static Temperature Add(this IMeasurement<ITemperatureUnit> measurement, double scalar)
//            => new Temperature(measurement.Value + scalar, measurement.Unit);

//        public static Temperature Subtract(this IMeasurement<ITemperatureUnit> measurement, double scalar)
//            => new Temperature(measurement.Value - scalar, measurement.Unit);

//        public static Temperature MultiplyBy(this IMeasurement<ITemperatureUnit> measurement, double scalar)
//            => new Temperature(measurement.Value * scalar, measurement.Unit);

//        public static Temperature DivideBy(this IMeasurement<ITemperatureUnit> measurement, double scalar)
//            => new Temperature(measurement.Value / scalar, measurement.Unit);

//        public static Temperature Add(this IMeasurement<ITemperatureUnit> left, IMeasurement<ITemperatureUnit> right)
//            => Temperature.Of<Kelvin>(left.ValueInKelvin() + right.ValueInKelvin()).To(left.Unit);

//        public static Temperature Subtract(this IMeasurement<ITemperatureUnit> left, IMeasurement<ITemperatureUnit> right)
//            => Temperature.Of<Kelvin>(left.ValueInKelvin() - right.ValueInKelvin()).To(left.Unit);

//        #endregion


//        #region Conversions

//        public static Temperature ToTemperature<TUnit>(this double value) where TUnit : ITemperatureUnit
//            => value.ToTemperature(UnitRegistry.GetUnit<TUnit>());

//        public static Temperature ToTemperature<TUnit>(this double value, TUnit unit) where TUnit : ITemperatureUnit
//            => new Temperature(value, unit);

//        public static Temperature ToTemperature<TUnit>(this float value) where TUnit : ITemperatureUnit
//            => value.ToTemperature(UnitRegistry.GetUnit<TUnit>());

//        public static Temperature ToTemperature<TUnit>(this float value, TUnit unit) where TUnit : ITemperatureUnit
//            => new Temperature(value, unit);

//        public static Temperature ToTemperature<TUnit>(this decimal value) where TUnit : ITemperatureUnit
//            => value.ToTemperature(UnitRegistry.GetUnit<TUnit>());

//        public static Temperature ToTemperature<TUnit>(this decimal value, TUnit unit) where TUnit : ITemperatureUnit
//            => new Temperature((double)value, unit);

//        public static Temperature ToTemperature<TUnit>(this int value) where TUnit : ITemperatureUnit
//            => value.ToTemperature(UnitRegistry.GetUnit<TUnit>());

//        public static Temperature ToTemperature<TUnit>(this int value, TUnit unit) where TUnit : ITemperatureUnit
//            => new Temperature(value, unit);

//        public static Temperature ToTemperature<TUnit>(this long value) where TUnit : ITemperatureUnit
//            => value.ToTemperature(UnitRegistry.GetUnit<TUnit>());

//        public static Temperature ToTemperature<TUnit>(this long value, TUnit unit) where TUnit : ITemperatureUnit
//            => new Temperature(value, unit);

//        public static Temperature ToTemperatureTemperature<T>(this T measurement) where T : IMeasurement<ITemperatureUnit>
//            => measurement is Temperature temperature ? temperature : measurement.CreateTemperature();

//        public static Temperature To<TUnit>(this IMeasurement<ITemperatureUnit> length) where TUnit : ITemperatureUnit
//            => length.To(UnitRegistry.GetUnit<TUnit>());

//        public static Temperature To<TUnit>(this IMeasurement<ITemperatureUnit> length, TUnit targetUnit) where TUnit : ITemperatureUnit
//            => targetUnit.FromKelvin(length.ValueInKelvin()).ToTemperature(targetUnit);

//        #endregion



//        private static double ValueInKelvin<T>(this T measurement) where T : IMeasurement<ITemperatureUnit> => measurement.Unit.ToKelvin(measurement.Value);

//        private static Temperature CreateTemperature(this IMeasurement<ITemperatureUnit> measurement)
//            => measurement != null ? new Temperature(measurement.Value, measurement.Unit) : throw new ArgumentNullException(nameof(measurement));
//    }
//}
