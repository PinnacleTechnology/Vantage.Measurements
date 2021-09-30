using System;
using Vantage.Measurements.Registration;

namespace Vantage.Measurements.Units.Acceleration
{
    public class CompositeAcceleration<TLength, TTime> : IAccelerationUnit, ICompositeUnit<TLength, TTime>
        where TLength : class, ILengthUnit
        where TTime : class, ITimeUnit
    {
        private readonly Lazy<TLength> _lengthUnitLazy = new Lazy<TLength>(UnitRegistry.Get<TLength>());
        private readonly Lazy<TTime> _timeUnitLazy = new Lazy<TTime>(UnitRegistry.Get<TTime>());

        private string? _symbolOverride;
        private string? _nameOverride;
        private string? _pluralNameOverride;

        public string Symbol
        {
            get => _symbolOverride ?? $"{LengthUnit.Symbol}/{TimeUnit.Symbol}{Symbols.Super2}";
            set => _symbolOverride = value;
        }

        public string Name
        {
            get => _nameOverride ?? $"{LengthUnit.PluralName} per {TimeUnit.PluralName} squared";
            set => _nameOverride = value;
        }

        public string PluralName
        {
            get => _pluralNameOverride ?? Name;
            set => _pluralNameOverride = value;
        }

        public UnitSystem System => LengthUnit.System & TimeUnit.System;

        private TLength LengthUnit => _lengthUnitLazy.Value;

        private TTime TimeUnit => _timeUnitLazy.Value;

        public double ToMetersPerSecondSquared(double value)
            => value * (LengthUnit.ToMeters(1) / Math.Pow(TimeUnit.ToSeconds(1), 2));

        public double FromMetersPerSecondSquared(double value)
            => value * (LengthUnit.FromMeters(1) / Math.Pow(TimeUnit.FromSeconds(1), 2));
    }
}