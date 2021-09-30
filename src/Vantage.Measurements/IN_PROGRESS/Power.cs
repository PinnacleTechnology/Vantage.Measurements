//using System;
//using System.Globalization;
//using Vantage.Measurements.Units.Power;

//namespace Vantage.Measurements
//{
//    public struct Power : IEquatable<Power>, IMeasurement<IPowerUnit>
//    {
//        private readonly double _watts;

//        public double Value { get; }
//        public IPowerUnit Unit { get; }

//        public Power(double value, IPowerUnit unit)
//        {
//            Value = value;
//            Unit = unit;
//            _watts = unit.ToWatts(value);
//        }

//        public static Power New<T>(double value) where T : IPowerUnit
//        {
//            return new Power(value, Measurements.UnitRegistry.GetUnit<T>());
//        }

//        public bool Equals(Power other)
//        {
//            return _watts.IsEqualTo(other._watts);
//        }

//        public override bool Equals(object obj)
//        {
//            return obj is Power other && Equals(other);
//        }

//        public override int GetHashCode()
//        {
//            return _watts.GetHashCode();
//        }

//        public override string ToString()
//        {
//            return Unit.Format(Value, "F3", NumberFormatInfo.CurrentInfo);
//        }

//        public static bool operator ==(Power left, Power right)
//        {
//            return left.Equals(right);
//        }

//        public static bool operator !=(Power left, Power right)
//        {
//            return !left.Equals(right);
//        }
//    }
//}