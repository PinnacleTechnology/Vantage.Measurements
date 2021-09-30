using System;
using System.Globalization;
using Vantage.Measurements.Registration;
using Vantage.Numerics;

namespace Vantage.Measurements
{
    public abstract class Measurement<TMeasurement, TUnit> : IMeasurement<TUnit>, IEquatable<IMeasurement<TUnit>>, IComparable, IComparable<IMeasurement<TUnit>>, IFormattable
        where TMeasurement : class, IMeasurement<TUnit>
        where TUnit : class, IUnit
    {
        protected Measurement(double value, TUnit unit)
        {
            Value = value;
            Unit = unit ?? throw new ArgumentNullException(nameof(unit));
        }

        protected Measurement(IMeasurement<TUnit> measurement)
        {
            if (measurement == null)
                throw new ArgumentNullException(nameof(measurement));

            Value = measurement.Value;
            Unit = measurement.Unit ?? throw new ArgumentNullException(nameof(measurement.Unit));
        }

        public double Value { get;  }

        public TUnit Unit { get; }

        IUnit IMeasurement.Unit => Unit;

        protected double BaseValue { get; init; }

        protected abstract TUnit BaseUnit { get; }

        public int CompareTo(IMeasurement<TUnit>? other)
            => other == null ? 1 : BaseValue.CompareTo(Wrap(other).BaseValue);

        public int CompareTo(object? obj)
            => CompareTo(obj as IMeasurement<TUnit>);

        public TMeasurement ConvertTo<T>() where T : class, TUnit
            => ConvertTo(UnitRegistry.Get<T>());

        public bool Equals(IMeasurement<TUnit>? other)
            => other != null && BaseValue.IsEqualTo(Wrap(other).BaseValue);

        public override bool Equals(object? obj)
            => obj is IMeasurement<TUnit> measurement && Equals(measurement);

        public override int GetHashCode()
            => BaseValue.GetHashCode();

        public override string ToString()
            => ToString("F6", NumberFormatInfo.CurrentInfo);

        public string ToString(string? format)
            => ToString(format, NumberFormatInfo.CurrentInfo);

        public string ToString(string? format, IFormatProvider? formatProvider)
            => $"{Value.ToString(format, formatProvider)} {Unit.Symbol}";

        public abstract TMeasurement ConvertTo(TUnit targetUnit);

        protected abstract Measurement<TMeasurement, TUnit> Wrap(IMeasurement<TUnit> measurement);

        protected abstract Measurement<TMeasurement, TUnit> Create(double value, TUnit unit);

        private TMeasurement Unwrap() => this as TMeasurement ?? throw new InvalidCastException();

        public static bool operator ==(Measurement<TMeasurement, TUnit> x, IMeasurement<TUnit> y) => x.Equals(y);

        public static bool operator !=(Measurement<TMeasurement, TUnit> x, IMeasurement<TUnit> y) => !x.Equals(y);

        public static bool operator >(Measurement<TMeasurement, TUnit> x, IMeasurement<TUnit> y) => x.CompareTo(y) > 0;

        public static bool operator <(Measurement<TMeasurement, TUnit> x, IMeasurement<TUnit> y) => x.CompareTo(y) < 0;

        public static bool operator >=(Measurement<TMeasurement, TUnit> x, IMeasurement<TUnit> y) => x > y || x == y;

        public static bool operator <=(Measurement<TMeasurement, TUnit> x, IMeasurement<TUnit> y) => x < y || x == y;

        public static TMeasurement operator +(Measurement<TMeasurement, TUnit> measurement, double scalar) => measurement.Create(measurement.Value + scalar, measurement.Unit).Unwrap();

        public static TMeasurement operator -(Measurement<TMeasurement, TUnit> measurement, double scalar) => measurement.Create(measurement.Value - scalar, measurement.Unit).Unwrap();

        public static TMeasurement operator *(Measurement<TMeasurement, TUnit> measurement, double scalar) => measurement.Create(measurement.Value * scalar, measurement.Unit).Unwrap();

        public static TMeasurement operator /(Measurement<TMeasurement, TUnit> measurement, double scalar) => measurement.Create(measurement.Value / scalar, measurement.Unit).Unwrap();

        public static TMeasurement operator %(Measurement<TMeasurement, TUnit> measurement, double scalar) => measurement.Create(measurement.Value % scalar, measurement.Unit).Unwrap();

        public static TMeasurement operator -(Measurement<TMeasurement, TUnit> measurement) => measurement.Create(-measurement.Value, measurement.Unit).Unwrap();

        public static TMeasurement operator +(Measurement<TMeasurement, TUnit> x, IMeasurement<TUnit> y)
            => x.Create(x.BaseValue + x.Wrap(y).BaseValue, x.BaseUnit).ConvertTo(x.Unit);

        public static TMeasurement operator -(Measurement<TMeasurement, TUnit> x, IMeasurement<TUnit> y)
            => x.Create(x.BaseValue - x.Wrap(y).BaseValue, x.BaseUnit).ConvertTo(x.Unit);

        public static explicit operator double(Measurement<TMeasurement, TUnit> measurement) => measurement.Value;

        public static explicit operator int(Measurement<TMeasurement, TUnit> measurement) => (int)measurement.Value;

        public static explicit operator long(Measurement<TMeasurement, TUnit> measurement) => (long)measurement.Value;

        public static explicit operator float(Measurement<TMeasurement, TUnit> measurement) => (float)measurement.Value;

        public static explicit operator decimal(Measurement<TMeasurement, TUnit> measurement) => (decimal)measurement.Value;
    }
}