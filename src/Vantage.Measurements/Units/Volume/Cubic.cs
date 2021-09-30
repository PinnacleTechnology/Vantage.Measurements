using System;
using Vantage.Measurements.Registration;

namespace Vantage.Measurements.Units.Volume
{
    public class Cubic<TLength> : IVolumeUnit, ICompositeUnit<TLength> where TLength : class, ILengthUnit
    {
        private readonly Lazy<TLength> _lengthUnit = new Lazy<TLength>(UnitRegistry.Get<TLength>());

        private string? _symbolOverride;
        private string? _nameOverride;
        private string? _pluralNameOverride;

        public string Symbol
        {
            get => _symbolOverride ?? $"{LengthUnit.Symbol}{Symbols.Super3}";
            set => _symbolOverride = value;
        }

        public string Name
        {
            get => _nameOverride ?? $"Cubic {LengthUnit.Name}";
            set => _nameOverride = value;
        }

        public string PluralName
        {
            get => _pluralNameOverride ?? $"Cubic {LengthUnit.PluralName}";
            set => _pluralNameOverride = value;
        }

        public UnitSystem System => LengthUnit.System;

        private TLength LengthUnit => _lengthUnit.Value;

        public double ToCubicMeters(double value)
            => value * Math.Pow(LengthUnit.ToMeters(1), 3);

        public double FromCubicMeters(double value)
            => value * Math.Pow(LengthUnit.FromMeters(1), 3);
    }
}