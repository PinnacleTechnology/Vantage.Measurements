using System;
using Vantage.Measurements.Registration;

namespace Vantage.Measurements.Units.Speed
{
    public class CompositeSpeed : CompositeUnit, ISpeedUnit
    {
        private readonly ILengthUnit _length;
        private readonly ITimeUnit _time;

        public CompositeSpeed(ILengthUnit length, ITimeUnit time)
        {
            _length = length;
            _time = time;
        }

        public override UnitSystem System => _length.System & _time.System;

        protected override string DefaultSymbol => $"{_length.Symbol}/{_time.Symbol}";

        protected override string DefaultName => $"{_length.PluralName} per {_time.Name}";

        public double ToMetersPerSecond(double value)
            => value * (_length.ToMeters(1) / _time.ToSeconds(1));

        public double FromMetersPerSecond(double value)
            => value * (_length.FromMeters(1) / _time.FromSeconds(1));
    }

    public class CompositeSpeed<TLength, TTime> : CompositeSpeed, ICompositeUnit<TLength, TTime>
        where TLength : class, ILengthUnit
        where TTime : class, ITimeUnit
    {
        public CompositeSpeed() : base(UnitRegistry.Get<TLength>(), UnitRegistry.Get<TTime>())
        {

        }

        public CompositeSpeed(ILengthUnit length, ITimeUnit time):base(length, time)
        {

        }
    }
}