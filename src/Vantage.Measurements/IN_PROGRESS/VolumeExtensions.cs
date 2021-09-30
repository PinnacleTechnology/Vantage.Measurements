//using System;

//using Vantage.Measurements.Units.Length;
//using Vantage.Measurements.Units.Volume;

//namespace Vantage.Measurements
//{
//    public static class VolumeExtensions
//    {
//        #region Operators

//        public static bool IsZero(this IMeasurement<IVolumeUnit> left, double precision = Precision.Default)
//            => left.ValueInCubicMeters().IsZero(precision);

//        public static bool IsEqualTo(this IMeasurement<IVolumeUnit> left, IMeasurement<IVolumeUnit> right, double precision = Precision.Default)
//            => left.ValueInCubicMeters().IsEqualTo(right.ValueInCubicMeters(), precision);

//        public static bool IsNotEqualTo(this IMeasurement<IVolumeUnit> left, IMeasurement<IVolumeUnit> right, double precision = Precision.Default)
//            => left.ValueInCubicMeters().IsNotEqualTo(right.ValueInCubicMeters(), precision);

//        public static bool IsGreaterThan(this IMeasurement<IVolumeUnit> left, IMeasurement<IVolumeUnit> right, double precision = Precision.Default)
//            => left.ValueInCubicMeters().IsGreaterThan(right.ValueInCubicMeters(), precision);

//        public static bool IsGreaterThanOrEqualTo(this IMeasurement<IVolumeUnit> left, IMeasurement<IVolumeUnit> right, double precision = Precision.Default)
//            => left.ValueInCubicMeters().IsGreaterThanOrEqualTo(right.ValueInCubicMeters(), precision);

//        public static bool IsLessThan(this IMeasurement<IVolumeUnit> left, IMeasurement<IVolumeUnit> right, double precision = Precision.Default)
//            => left.ValueInCubicMeters().IsLessThan(right.ValueInCubicMeters(), precision);

//        public static bool IsLessThanOrEqualTo(this IMeasurement<IVolumeUnit> left, IMeasurement<IVolumeUnit> right, double precision = Precision.Default)
//            => left.ValueInCubicMeters().IsLessThanOrEqualTo(right.ValueInCubicMeters(), precision);

//        public static Volume OffsetBy(this IMeasurement<IVolumeUnit> measurement, double offset)
//            => new Volume(measurement.Value + offset, measurement.Unit);

//        public static Volume ScaleBy(this IMeasurement<IVolumeUnit> measurement, double scalar)
//            => new Volume(measurement.Value * scalar, measurement.Unit);

//        public static Volume Add(this IMeasurement<IVolumeUnit> left, IMeasurement<IVolumeUnit> right)
//            => Volume.CubicMeters(left.ValueInCubicMeters() + right.ValueInCubicMeters()).To(left.Unit);

//        public static Volume Subtract(this IMeasurement<IVolumeUnit> left, IMeasurement<IVolumeUnit> right)
//            => Volume.CubicMeters(left.ValueInCubicMeters() - right.ValueInCubicMeters()).To(left.Unit);

//        #endregion


//        #region Conversions

//        public static Volume ToVolume<TUnit>(this double value) where TUnit : IVolumeUnit
//            => value.ToVolume(UnitRegistry.GetUnit<TUnit>());

//        public static Volume ToVolume<TUnit>(this double value, TUnit unit) where TUnit : IVolumeUnit
//            => new Volume(value, unit);

//        public static Volume ToVolume<TUnit>(this float value) where TUnit : IVolumeUnit
//            => value.ToVolume(UnitRegistry.GetUnit<TUnit>());

//        public static Volume ToVolume<TUnit>(this float value, TUnit unit) where TUnit : IVolumeUnit
//            => new Volume(value, unit);

//        public static Volume ToVolume<TUnit>(this decimal value) where TUnit : IVolumeUnit
//            => value.ToVolume(UnitRegistry.GetUnit<TUnit>());

//        public static Volume ToVolume<TUnit>(this decimal value, TUnit unit) where TUnit : IVolumeUnit
//            => new Volume((double)value, unit);

//        public static Volume ToVolume<TUnit>(this int value) where TUnit : IVolumeUnit
//            => value.ToVolume(UnitRegistry.GetUnit<TUnit>());

//        public static Volume ToVolume<TUnit>(this int value, TUnit unit) where TUnit : IVolumeUnit
//            => new Volume(value, unit);

//        public static Volume ToVolume<TUnit>(this long value) where TUnit : IVolumeUnit
//            => value.ToVolume(UnitRegistry.GetUnit<TUnit>());

//        public static Volume ToVolume<TUnit>(this long value, TUnit unit) where TUnit : IVolumeUnit
//            => new Volume(value, unit);

//        public static Volume ToVolume<T>(this T measurement) where T : IMeasurement<IVolumeUnit>
//            => measurement is Volume volume ? volume : measurement.CreateVolume();

//        public static Volume ToCubic<TUnit>(this IMeasurement<IVolumeUnit> volume) where TUnit : ILengthUnit
//            => volume.To(UnitRegistry.GetUnit<Cubic<TUnit>>());

//        public static Volume To<TUnit>(this IMeasurement<IVolumeUnit> volume) where TUnit : IVolumeUnit
//            => volume.To(UnitRegistry.GetUnit<TUnit>());

//        public static Volume To<TUnit>(this IMeasurement<IVolumeUnit> volume, TUnit targetUnit) where TUnit : IVolumeUnit
//            => targetUnit.FromCubicMeters(volume.ValueInCubicMeters()).ToVolume(targetUnit);

//        #endregion



//        private static double ValueInCubicMeters<T>(this T measurement) where T : IMeasurement<IVolumeUnit> => measurement.Unit.ToCubicMeters(measurement.Value);

//        private static Volume CreateVolume(this IMeasurement<IVolumeUnit> measurement)
//            => measurement != null ? new Volume(measurement.Value, measurement.Unit) : throw new ArgumentNullException(nameof(measurement));
//    }
//}
