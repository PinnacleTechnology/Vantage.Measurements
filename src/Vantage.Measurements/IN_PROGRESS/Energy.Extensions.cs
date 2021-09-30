//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.InteropServices.ComTypes;
//using Vantage.Measurements.Units.Energy;
//using Vantage.Measurements.Units.Force;
//using Vantage.Measurements.Units.Length;

//namespace Vantage.Measurements
//{
//    public static partial class MeasurementExtensions
//    {
//        public static Energy To<T>(this Energy measurement) where T : IEnergyUnit
//        {
//            return measurement.To(UnitRegistry.GetUnit<T>());
//        }

//        public static Energy To<TForce, TLength>(this Energy measurement)
//            where TForce : IForceUnit
//            where TLength : ILengthUnit
//        {
//            var unit = UnitRegistry.GetUnit<CompositeEnergy<TForce, TLength>>();
//            return measurement.To(unit);
//        }

//        public static Energy To(this Energy measurement, IEnergyUnit target)
//        {
//            var baseValue = measurement.Unit.ToJoules(measurement.Value);
//            return new Energy(target.FromJoules(baseValue), target);
//        }

//        public static Energy Add(this Energy left, Energy right)
//        {
//            var convertedRight = right.To(left.Unit);
//            return new Energy(left.Value + convertedRight.Value, left.Unit);
//        }

//        public static Energy Add(this Energy measurement, double scalar)
//        {
//            return new Energy(measurement.Value + scalar, measurement.Unit);
//        }

//        public static Energy Subtract(this Energy left, Energy right)
//        {
//            var convertedRight = right.To(left.Unit);
//            return new Energy(left.Value - convertedRight.Value, left.Unit);
//        }

//        public static Energy Subtract(this Energy measurement, double scalar)
//        {
//            return new Energy(measurement.Value - scalar, measurement.Unit);
//        }

//        public static Energy MultiplyBy(this Energy measurement, double scalar)
//        {
//            return new Energy(measurement.Value * scalar, measurement.Unit);
//        }

//        public static Energy DivideBy(this Energy measurement, double scalar)
//        {
//            return new Energy(measurement.Value / scalar, measurement.Unit);
//        }
//    }
//}