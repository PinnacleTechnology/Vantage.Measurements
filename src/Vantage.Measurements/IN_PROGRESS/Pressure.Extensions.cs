//using Vantage.Measurements.Units;
//using Vantage.Measurements.Units.Area;
//using Vantage.Measurements.Units.Force;
//using Vantage.Measurements.Units.Pressure;

//namespace Vantage.Measurements
//{
//    public static partial class MeasurementExtensions
//    {
//        public static Pressure To<T>(this Pressure measurement) where T : IPressureUnit
//        {
//            return measurement.To(UnitRegistry.GetUnit<T>());
//        }

//        public static Pressure To<TForce, TArea>(this Pressure measurement) where TForce : IForceUnit where TArea : IAreaUnit
//        {
//            var unit = UnitRegistry.GetUnit<CompositePressure<TForce, TArea>>();
//            return measurement.To(unit);
//        }

//        public static Pressure To(this Pressure measurement, IPressureUnit unit)
//        {
//            var baseValue = measurement.Unit.ToPascals(measurement.Value);
//            return new Pressure(unit.FromPascals(baseValue), unit);
//        }

//        public static Pressure Add(this Pressure left, Pressure right)
//        {
//            var convertedRight = right.To(left.Unit);
//            return new Pressure(left.Value + convertedRight.Value, left.Unit);
//        }

//        public static Pressure Add(this Pressure measurement, double scalar)
//        {
//            return new Pressure(measurement.Value + scalar, measurement.Unit);
//        }

//        public static Pressure Subtract(this Pressure left, Pressure right)
//        {
//            var convertedRight = right.To(left.Unit);
//            return new Pressure(left.Value - convertedRight.Value, left.Unit);
//        }

//        public static Pressure Subtract(this Pressure measurement, double scalar)
//        {
//            return new Pressure(measurement.Value - scalar, measurement.Unit);
//        }

//        public static Pressure MultiplyBy(this Pressure measurement, double scalar)
//        {
//            return new Pressure(measurement.Value * scalar, measurement.Unit);
//        }

//        public static Pressure DivideBy(this Pressure measurement, double scalar)
//        {
//            return new Pressure(measurement.Value / scalar, measurement.Unit);
//        }
//    }
//}