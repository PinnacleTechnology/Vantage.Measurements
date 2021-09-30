//using System;

//using Vantage.Measurements.Units.DigitalStorage;
//using Byte = Vantage.Measurements.Units.DigitalStorage.Byte;

//namespace Vantage.Measurements
//{
//    public static class DigitalStorageExtensions
//    {
//        #region Operators

//        public static bool IsEqualTo(this IMeasurement<IDigitalStorageUnit> left, IMeasurement<IDigitalStorageUnit> right, double precision = Precision.Default)
//            => left.ValueInBytes().IsEqualTo(right.ValueInBytes(), precision);

//        public static bool IsNotEqualTo(this IMeasurement<IDigitalStorageUnit> left, IMeasurement<IDigitalStorageUnit> right, double precision = Precision.Default)
//            => left.ValueInBytes().IsNotEqualTo(right.ValueInBytes(), precision);

//        public static bool IsGreaterThan(this IMeasurement<IDigitalStorageUnit> left, IMeasurement<IDigitalStorageUnit> right, double precision = Precision.Default)
//            => left.ValueInBytes().IsGreaterThan(right.ValueInBytes(), precision);

//        public static bool IsGreaterThanOrEqualTo(this IMeasurement<IDigitalStorageUnit> left, IMeasurement<IDigitalStorageUnit> right, double precision = Precision.Default)
//            => left.ValueInBytes().IsGreaterThanOrEqualTo(right.ValueInBytes(), precision);

//        public static bool IsLessThan(this IMeasurement<IDigitalStorageUnit> left, IMeasurement<IDigitalStorageUnit> right, double precision = Precision.Default)
//            => left.ValueInBytes().IsLessThan(right.ValueInBytes(), precision);

//        public static bool IsLessThanOrEqualTo(this IMeasurement<IDigitalStorageUnit> left, IMeasurement<IDigitalStorageUnit> right, double precision = Precision.Default)
//            => left.ValueInBytes().IsLessThanOrEqualTo(right.ValueInBytes(), precision);

//        public static DigitalStorage Add(this IMeasurement<IDigitalStorageUnit> measurement, double scalar)
//            => new DigitalStorage(measurement.Value + scalar, measurement.Unit);

//        public static DigitalStorage Subtract(this IMeasurement<IDigitalStorageUnit> measurement, double scalar)
//            => new DigitalStorage(measurement.Value - scalar, measurement.Unit);

//        public static DigitalStorage MultiplyBy(this IMeasurement<IDigitalStorageUnit> measurement, double scalar)
//            => new DigitalStorage(measurement.Value * scalar, measurement.Unit);

//        public static DigitalStorage DivideBy(this IMeasurement<IDigitalStorageUnit> measurement, double scalar)
//            => new DigitalStorage(measurement.Value / scalar, measurement.Unit);

//        public static DigitalStorage Add(this IMeasurement<IDigitalStorageUnit> left, IMeasurement<IDigitalStorageUnit> right)
//            => DigitalStorage.Of<Byte>(left.ValueInBytes() + right.ValueInBytes()).To(left.Unit);

//        public static DigitalStorage Subtract(this IMeasurement<IDigitalStorageUnit> left, IMeasurement<IDigitalStorageUnit> right)
//            => DigitalStorage.Of<Byte>(left.ValueInBytes() - right.ValueInBytes()).To(left.Unit);

//        #endregion


//        #region Conversions

//        public static DigitalStorage As<TUnit>(this double value) where TUnit : IDigitalStorageUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static DigitalStorage As(this double value, IDigitalStorageUnit unit)
//            => new DigitalStorage(value, unit);

//        public static DigitalStorage As<TUnit>(this float value) where TUnit : IDigitalStorageUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static DigitalStorage As(this float value, IDigitalStorageUnit unit)
//            => new DigitalStorage(value, unit);

//        public static DigitalStorage As<TUnit>(this decimal value) where TUnit : IDigitalStorageUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static DigitalStorage As(this decimal value, IDigitalStorageUnit unit)
//            => new DigitalStorage((double)value, unit);

//        public static DigitalStorage As<TUnit>(this int value) where TUnit : IDigitalStorageUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static DigitalStorage As(this int value, IDigitalStorageUnit unit)
//            => new DigitalStorage(value, unit);

//        public static DigitalStorage As<TUnit>(this long value) where TUnit : IDigitalStorageUnit
//            => value.As(UnitRegistry.GetUnit<TUnit>());

//        public static DigitalStorage As(this long value, IDigitalStorageUnit unit)
//            => new DigitalStorage(value, unit);

//        public static DigitalStorage AsDigitalStorage<T>(this T measurement) where T : IMeasurement<IDigitalStorageUnit>
//            => measurement is DigitalStorage length ? length : CreateDigitalStorage(measurement);

//        public static DigitalStorage To<TUnit>(this IMeasurement<IDigitalStorageUnit> length) where TUnit : IDigitalStorageUnit
//            => length.To(UnitRegistry.GetUnit<TUnit>());

//        public static DigitalStorage To(this IMeasurement<IDigitalStorageUnit> length, IDigitalStorageUnit targetUnit)
//            => targetUnit.FromBytes(length.ValueInBytes()).As(targetUnit);

//        #endregion


        
        
        
//        private static double ValueInBytes<T>(this T measurement) where T : IMeasurement<IDigitalStorageUnit> => measurement.Unit.ToBytes(measurement.Value);

//        private static DigitalStorage CreateDigitalStorage(this IMeasurement<IDigitalStorageUnit> measurement)
//            => measurement != null ? new DigitalStorage(measurement.Value, measurement.Unit) : throw new ArgumentNullException(nameof(measurement));
//    }
//}
