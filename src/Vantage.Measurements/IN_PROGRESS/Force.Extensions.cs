//using Vantage.Measurements.Units.Force;
//using Vantage.Measurements.Units.Length;
//using Vantage.Measurements.Units.Mass;
//using Vantage.Measurements.Units.Time;

//namespace Vantage.Measurements
//{
//    public static partial class MeasurementExtensions
//    {
//        public static Force To<T>(this Force measurement) where T : IForceUnit
//        {
//            return measurement.To(UnitRegistry.GetUnit<T>());
//        }

//        public static Force To<TMass, TLen, TTime>(this Force measurement) 
//            where TMass : IMassUnit
//            where TLen : ILengthUnit
//            where TTime : ITimeUnit
//        {
//            var unit = UnitRegistry.GetUnit<CompositeForce<TMass, TLen, TTime>>();
//            return measurement.To(unit);
//        }

//        public static Force To(this Force measurement, IForceUnit unit)
//        {
//            var baseValue = measurement.Unit.ToNewtons(measurement.Value);
//            return new Force(unit.FromNewtons(baseValue), unit);
//        }

//        public static Force Add(this Force left, Force right)
//        {
//            var convertedRight = right.To(left.Unit);
//            return new Force(left.Value + convertedRight.Value, left.Unit);
//        }

//        public static Force Add(this Force measurement, double scalar)
//        {
//            return new Force(measurement.Value + scalar, measurement.Unit);
//        }

//        public static Force Subtract(this Force left, Force right)
//        {
//            var convertedRight = right.To(left.Unit);
//            return new Force(left.Value - convertedRight.Value, left.Unit);
//        }

//        public static Force Subtract(this Force measurement, double scalar)
//        {
//            return new Force(measurement.Value - scalar, measurement.Unit);
//        }

//        public static Force MultiplyBy(this Force measurement, double scalar)
//        {
//            return new Force(measurement.Value * scalar, measurement.Unit);
//        }

//        public static Force DivideBy(this Force measurement, double scalar)
//        {
//            return new Force(measurement.Value / scalar, measurement.Unit);
//        }
//    }
//}