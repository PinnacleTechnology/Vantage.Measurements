namespace Vantage.Measurements
{
    public interface ICompositeUnit : IUnit
    {

    }

    public interface ICompositeUnit<T> : ICompositeUnit
        where T : IUnit
    {

    }

    public interface ICompositeUnit<T1, T2> : ICompositeUnit
        where T1 : IUnit
        where T2 : IUnit
    {

    }

    public interface ICompositeUnit<T1, T2, T3> : ICompositeUnit
        where T1 : IUnit
        where T2 : IUnit
        where T3 : IUnit
    {

    }

    public abstract class CompositeUnit : ICompositeUnit
    {
        private string? _symbolOverride;
        private string? _nameOverride;
        private string? _pluralNameOverride;

        public string Symbol
        {
            get => _symbolOverride ?? DefaultSymbol;
            set => _symbolOverride = value;
        }

        public string Name
        {
            get => _nameOverride ?? DefaultName;
            set => _nameOverride = value;
        }

        public string PluralName
        {
            get => _pluralNameOverride ?? Name;
            set => _pluralNameOverride = value;
        }

        public abstract UnitSystem System { get; }
        protected abstract string DefaultSymbol { get; }
        protected abstract string DefaultName { get; }
    }
}