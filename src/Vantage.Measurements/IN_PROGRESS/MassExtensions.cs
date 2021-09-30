//using System;

//using Vantage.Measurements.Units.Mass;

//namespace Vantage.Measurements
//{
//    public static class MassExtensions
//    {
//        #region Operators

//        public static bool IsZero(this IMeasurement<IMassUnit> left, double precision = Precision.Default)
//            => left.ValueInKilograms().IsZero(precision);

//        public static bool IsEqualTo(this IMeasurement<IMassUnit> left, IMeasurement<IMassUnit> right, double precision = Precision.Default)
//            => left.ValueInKilograms().IsEqualTo(right.ValueInKilograms(), precision);

//        public static bool IsNotEqualTo(this IMeasurement<IMassUnit> left, IMeasurement<IMassUnit> right, double precision = Precision.Default)
//            => left.ValueInKilograms().IsNotEqualTo(right.ValueInKilograms(), precision);

//        public static bool IsGreaterThan(this IMeasurement<IMassUnit> left, IMeasurement<IMassUnit> right, double precision = Precision.Default)
//            => left.ValueInKilograms().IsGreaterThan(right.ValueInKilograms(), precision);

//        public static bool IsGreaterThanOrEqualTo(this IMeasurement<IMassUnit> left, IMeasurement<IMassUnit> right, double precision = Precision.Default)
//            => left.ValueInKilograms().IsGreaterThanOrEqualTo(right.ValueInKilograms(), precision);

//        public static bool IsLessThan(this IMeasurement<IMassUnit> left, IMeasurement<IMassUnit> right, double precision = Precision.Default)
//            => left.ValueInKilograms().IsLessThan(right.ValueInKilograms(), precision);

//        public static bool IsLessThanOrEqualTo(this IMeasurement<IMassUnit> left, IMeasurement<IMassUnit> right, double precision = Precision.Default)
//            => left.ValueInKilograms().IsLessThanOrEqualTo(right.ValueInKilograms(), precision);

//        public static Mass Add(this IMeasurement<IMassUnit> measurement, double scalar)
//            => new Mass(measurement.Value + scalar, measurement.Unit);

//        public static Mass Subtract(this IMeasurement<IMassUnit> measurement, double scalar)
//            => new Mass(measurement.Value - scalar, measurement.Unit);

//        public static Mass MultiplyBy(this IMeasurement<IMassUnit> measurement, double scalar)
//            => new Mass(measurement.Value * scalar, measurement.Unit);

//        public static Mass DivideBy(this IMeasurement<IMassUnit> measurement, double scalar)
//            => new Mass(measurement.Value / scalar, measurement.Unit);

//        public static Mass Add(this IMeasurement<IMassUnit> left, IMeasurement<IMassUnit> right)
//            => Mass.Kilograms(left.ValueInKilograms() + right.ValueInKilograms()).To(left.Unit);

//        public static Mass Subtract(this IMeasurement<IMassUnit> left, IMeasurement<IMassUnit> right)
//            => Mass.Kilograms(left.ValueInKilograms() - right.ValueInKilograms()).To(left.Unit);

//        #endregion


//        #region Conversions

//        public static Mass ToMass<TUnit>(this double value) where TUnit : IMassUnit
//            => value.ToMass(UnitRegistry.GetUnit<TUnit>());

//        public static Mass ToMass<TUnit>(this double value, TUnit unit) where TUnit : IMassUnit
//            => new Mass(value, unit);

//        public static Mass ToMass<TUnit>(this float value) where TUnit : IMassUnit
//            => value.ToMass(UnitRegistry.GetUnit<TUnit>());

//        public static Mass ToMass<TUnit>(this float value, TUnit unit) where TUnit : IMassUnit
//            => new Mass(value, unit);

//        public static Mass ToMass<TUnit>(this decimal value) where TUnit : IMassUnit
//            => value.ToMass(UnitRegistry.GetUnit<TUnit>());

//        public static Mass ToMass<TUnit>(this decimal value, TUnit unit) where TUnit : IMassUnit
//            => new Mass((double)value, unit);

//        public static Mass ToMass<TUnit>(this int value) where TUnit : IMassUnit
//            => value.ToMass(UnitRegistry.GetUnit<TUnit>());

//        public static Mass ToMass<TUnit>(this int value, TUnit unit) where TUnit : IMassUnit
//            => new Mass(value, unit);

//        public static Mass ToMass<TUnit>(this long value) where TUnit : IMassUnit
//            => value.ToMass(UnitRegistry.GetUnit<TUnit>());

//        public static Mass ToMass<TUnit>(this long value, TUnit unit) where TUnit : IMassUnit
//            => new Mass(value, unit);

//        public static Mass ToMassMass<T>(this T measurement) where T : IMeasurement<IMassUnit>
//            => measurement is Mass mass ? mass : CreateMass(measurement);

//        public static Mass To<TUnit>(this IMeasurement<IMassUnit> measurement) where TUnit : IMassUnit
//            => measurement.To(UnitRegistry.GetUnit<TUnit>());

//        public static Mass To<TUnit>(this IMeasurement<IMassUnit> measurement, TUnit targetUnit) where TUnit : IMassUnit
//            => targetUnit.FromKilograms(measurement.ValueInKilograms()).ToMass(targetUnit);

//        #endregion






//        private static double ValueInKilograms<T>(this T measurement) where T : IMeasurement<IMassUnit> => measurement.Unit.ToKilograms(measurement.Value);

//        private static Mass CreateMass(this IMeasurement<IMassUnit> measurement)
//            => measurement != null ? new Mass(measurement.Value, measurement.Unit) : throw new ArgumentNullException(nameof(measurement));
//    }
//}
