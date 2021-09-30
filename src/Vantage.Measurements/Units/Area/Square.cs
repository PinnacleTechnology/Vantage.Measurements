using System;
using Vantage.Measurements.Registration;

namespace Vantage.Measurements.Units.Area
{
    public class Square<TLength> : CompositeUnit, IAreaUnit, ICompositeUnit<TLength> where TLength : class, ILengthUnit
    {
        private readonly Lazy<TLength> _lengthUnit = new Lazy<TLength>(UnitRegistry.Get<TLength>());

        public override UnitSystem System => LengthUnit.System;

        protected override string DefaultSymbol=> $"{LengthUnit.Symbol}{Symbols.Super2}";

        protected override string DefaultName => $"Square {LengthUnit.Name}";

        private TLength LengthUnit => _lengthUnit.Value;

        public double ToSquareMeters(double value)
            => value * Math.Pow(LengthUnit.ToMeters(1), 2);

        public double FromSquareMeters(double value)
            => value * Math.Pow(LengthUnit.FromMeters(1), 2);
    }
}