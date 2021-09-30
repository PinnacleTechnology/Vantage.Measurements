using System;
using Vantage.Measurements.Prefixes;
using Vantage.Measurements.Registration;

namespace Vantage.Measurements
{
    public interface IPrefixedUnit<out TPrefix, TUnit> : ICompositeUnit<TUnit>
        where TPrefix : IPrefix
        where TUnit : IUnit

    {
        TPrefix Prefix { get; }
    }

    public abstract class PrefixedUnit<TPrefix, TUnit> : CompositeUnit, IPrefixedUnit<TPrefix, TUnit>
        where TPrefix : IPrefix
        where TUnit : class, IUnit
    {
        private readonly Lazy<TPrefix> _prefixLazy = new Lazy<TPrefix>(UnitRegistry.GetPrefix<TPrefix>());
        private readonly Lazy<TUnit> _unitLazy = new Lazy<TUnit>(UnitRegistry.Get<TUnit>());

        public TPrefix Prefix => _prefixLazy.Value;

        public override UnitSystem System => Unit.System;

        protected override string DefaultName => $"{Prefix.Name}{Unit.Name.ToLower()}";

        protected override string DefaultSymbol => $"{Prefix.Symbol}{Unit.Symbol}";

        protected TUnit Unit => _unitLazy.Value;
    }
}