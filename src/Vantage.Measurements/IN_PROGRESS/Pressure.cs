//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Text;
//using Vantage.Measurements.Units;
//using Vantage.Measurements.Units.Area;
//using Vantage.Measurements.Units.Force;
//using Vantage.Measurements.Units.Pressure;

//namespace Vantage.Measurements
//{
//    public struct Pressure : IEquatable<Pressure>, IMeasurement<IPressureUnit>
//    {
//        private readonly double _pascals;
//        public double Value { get; }
//        public IPressureUnit Unit { get; }

//        public Pressure(double value, IPressureUnit unit)
//        {
//            Value = value;
//            Unit = unit;
//            _pascals = unit.ToPascals(value);
//        }

//        public static Pressure New<T>(double value) where T : IPressureUnit
//        {
//            return new Pressure(value, Measurements.UnitRegistry.GetUnit<T>());
//        }

//        public static Pressure New<TForce, TArea>(double value) where TForce : IForceUnit where TArea : IAreaUnit
//        {
//            return new Pressure(value, Measurements.UnitRegistry.GetUnit<CompositePressure<TForce, TArea>>());
//        }

//        public bool Equals(Pressure other)
//        {
//            return _pascals.IsEqualTo(other._pascals);
//        }

//        public override bool Equals(object obj)
//        {
//            return obj is Pressure other && Equals(other);
//        }

//        public override int GetHashCode()
//        {
//            return _pascals.GetHashCode();
//        }

//        public override string ToString()
//        {
//            return Unit.Format(Value, "F3", NumberFormatInfo.CurrentInfo);
//        }

//        public static bool operator ==(Pressure left, Pressure right)
//        {
//            return left.Equals(right);
//        }

//        public static bool operator !=(Pressure left, Pressure right)
//        {
//            return !left.Equals(right);
//        }

//        public static Pressure operator +(Pressure pressure, double scalar)
//        {
//            return pressure.Add(scalar);
//        }

//        public static Pressure operator -(Pressure pressure, double scalar)
//        {
//            return pressure.Subtract(scalar);
//        }

//        public static Pressure operator *(Pressure pressure, double scalar)
//        {
//            return pressure.MultiplyBy(scalar);
//        }

//        public static Pressure operator /(Pressure pressure, double scalar)
//        {
//            return pressure.DivideBy(scalar);
//        }

//        public static Pressure operator +(Pressure left, Pressure right)
//        {
//            return left.Add(right);
//        }

//        public static Pressure operator -(Pressure left, Pressure right)
//        {
//            return left.Subtract(right);
//        }

//        public static explicit operator double(Pressure pressure)
//        {
//            return pressure.Value;
//        }
//    }
//}
