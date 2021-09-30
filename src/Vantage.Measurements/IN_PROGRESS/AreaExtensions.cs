//using System;

//using Vantage.Measurements.Units.Area;
//using Vantage.Measurements.Units.Length;

//namespace Vantage.Measurements
//{
//    public static class AreaExtensions
//    {
//        #region Operators

//        public static bool IsZero(this IMeasurement<IAreaUnit> left, double precision = Precision.Default)
//            => left.ValueInSquareMeters().IsZero(precision);

//        public static bool IsEqualTo(this IMeasurement<IAreaUnit> left, IMeasurement<IAreaUnit> right, double precision = Precision.Default)
//            => left.ValueInSquareMeters().IsEqualTo(right.ValueInSquareMeters(), precision);

//        public static bool IsNotEqualTo(this IMeasurement<IAreaUnit> left, IMeasurement<IAreaUnit> right, double precision = Precision.Default)
//            => left.ValueInSquareMeters().IsNotEqualTo(right.ValueInSquareMeters(), precision);

//        public static bool IsGreaterThan(this IMeasurement<IAreaUnit> left, IMeasurement<IAreaUnit> right, double precision = Precision.Default)
//            => left.ValueInSquareMeters().IsGreaterThan(right.ValueInSquareMeters(), precision);

//        public static bool IsGreaterThanOrEqualTo(this IMeasurement<IAreaUnit> left, IMeasurement<IAreaUnit> right, double precision = Precision.Default)
//            => left.ValueInSquareMeters().IsGreaterThanOrEqualTo(right.ValueInSquareMeters(), precision);

//        public static bool IsLessThan(this IMeasurement<IAreaUnit> left, IMeasurement<IAreaUnit> right, double precision = Precision.Default)
//            => left.ValueInSquareMeters().IsLessThan(right.ValueInSquareMeters(), precision);

//        public static bool IsLessThanOrEqualTo(this IMeasurement<IAreaUnit> left, IMeasurement<IAreaUnit> right, double precision = Precision.Default)
//            => left.ValueInSquareMeters().IsLessThanOrEqualTo(right.ValueInSquareMeters(), precision);

//        public static Area Add(this IMeasurement<IAreaUnit> measurement, double scalar)
//            => new Area(measurement.Value + scalar, measurement.Unit);

//        public static Area Subtract(this IMeasurement<IAreaUnit> measurement, double scalar)
//            => new Area(measurement.Value - scalar, measurement.Unit);

//        public static Area MultiplyBy(this IMeasurement<IAreaUnit> measurement, double scalar)
//            => new Area(measurement.Value * scalar, measurement.Unit);

//        public static Area DivideBy(this IMeasurement<IAreaUnit> measurement, double scalar)
//            => new Area(measurement.Value / scalar, measurement.Unit);

//        public static Area Add(this IMeasurement<IAreaUnit> left, IMeasurement<IAreaUnit> right)
//            => Area.Square<Meter>(left.ValueInSquareMeters() + right.ValueInSquareMeters()).To(left.Unit);

//        public static Area Subtract(this IMeasurement<IAreaUnit> left, IMeasurement<IAreaUnit> right)
//            => Area.Square<Meter>(left.ValueInSquareMeters() - right.ValueInSquareMeters()).To(left.Unit);

//        #endregion


//        #region Conversions

//        public static Area ToArea<TUnit>(this double value) where TUnit : IAreaUnit
//            => value.ToArea(UnitRegistry.GetUnit<TUnit>());

//        public static Area ToArea(this double value, IAreaUnit unit)
//            => new Area(value, unit);

//        public static Area ToArea<TUnit>(this float value) where TUnit : IAreaUnit
//            => value.ToArea(UnitRegistry.GetUnit<TUnit>());

//        public static Area ToArea(this float value, IAreaUnit unit)
//            => new Area(value, unit);

//        public static Area ToArea<TUnit>(this decimal value) where TUnit : IAreaUnit
//            => value.ToArea(UnitRegistry.GetUnit<TUnit>());

//        public static Area ToArea(this decimal value, IAreaUnit unit)
//            => new Area((double)value, unit);

//        public static Area ToArea<TUnit>(this int value) where TUnit : IAreaUnit
//            => value.ToArea(UnitRegistry.GetUnit<TUnit>());

//        public static Area ToArea(this int value, IAreaUnit unit)
//            => new Area(value, unit);

//        public static Area ToArea<TUnit>(this long value) where TUnit : IAreaUnit
//            => value.ToArea(UnitRegistry.GetUnit<TUnit>());

//        public static Area ToArea(this long value, IAreaUnit unit)
//            => new Area(value, unit);

//        public static Area ToArea(this IMeasurement<IAreaUnit> measurement)
//            => measurement is Area area ? area : measurement.CreateArea();

//        public static Area ToSquare<TUnit>(this IMeasurement<IAreaUnit> measurement) where TUnit : ILengthUnit
//            => measurement.ToSquare(UnitRegistry.GetUnit<TUnit>());

//        public static Area ToSquare<TUnit>(this IMeasurement<IAreaUnit> measurement, TUnit targetUnit) where TUnit : ILengthUnit
//            => measurement.To(new Square<TUnit>(targetUnit));

//        public static Area To<TUnit>(this IMeasurement<IAreaUnit> measurement) where TUnit : IAreaUnit
//            => measurement.To(UnitRegistry.GetUnit<TUnit>());

//        public static Area To(this IMeasurement<IAreaUnit> measurement, IAreaUnit targetUnit)
//            => targetUnit.FromSquareMeters(measurement.ValueInSquareMeters()).ToArea(targetUnit);

//        #endregion
       

//        private static double ValueInSquareMeters<T>(this T measurement) where T : IMeasurement<IAreaUnit> => measurement.Unit.ToSquareMeters(measurement.Value);

//        private static Area CreateArea(this IMeasurement<IAreaUnit> measurement)
//            => measurement != null ? new Area(measurement.Value, measurement.Unit) : throw new ArgumentNullException(nameof(measurement));
//    }
//}
