//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Text;
//using Vantage.Measurements.Units.Energy;

//namespace Vantage.Measurements
//{
//    public struct Energy : IEquatable<Energy>, IMeasurement<IEnergyUnit>
//    {
//        private readonly double _joules;

//        public double Value { get; }
//        public IEnergyUnit Unit { get; }

//        public Energy(double value, IEnergyUnit unit)
//        {
//            Value = value;
//            Unit = unit;
//            _joules = unit.ToJoules(value);
//        }

//        public static Energy New<T>(double value) where T : IEnergyUnit
//        {
//            return new Energy(value, Measurements.UnitRegistry.GetUnit<T>());
//        }

//        public bool Equals(Energy other)
//        {
//            return _joules.IsEqualTo(other._joules);
//        }

//        public override bool Equals(object obj)
//        {
//            return obj is Energy other && Equals(other);
//        }

//        public override int GetHashCode()
//        {
//            return _joules.GetHashCode();
//        }

//        public override string ToString()
//        {
//            return Unit.Format(Value, "F3", NumberFormatInfo.CurrentInfo);
//        }

//        public static bool operator ==(Energy left, Energy right)
//        {
//            return left.Equals(right);
//        }

//        public static bool operator !=(Energy left, Energy right)
//        {
//            return !left.Equals(right);
//        }

//        public static Energy operator +(Energy energy, double scalar)
//        {
//            return energy.Add(scalar);
//        }

//        public static Energy operator -(Energy energy, double scalar)
//        {
//            return energy.Subtract(scalar);
//        }

//        public static Energy operator *(Energy energy, double scalar)
//        {
//            return energy.MultiplyBy(scalar);
//        }

//        public static Energy operator /(Energy energy, double scalar)
//        {
//            return energy.DivideBy(scalar);
//        }

//        public static Energy operator +(Energy left, Energy right)
//        {
//            return left.Add(right);
//        }

//        public static Energy operator -(Energy left, Energy right)
//        {
//            return left.Subtract(right);
//        }

//        public static explicit operator double(Energy energy)
//        {
//            return energy.Value;
//        }
//    }
//}
