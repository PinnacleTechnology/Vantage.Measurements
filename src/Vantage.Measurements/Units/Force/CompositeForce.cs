using System;
using Vantage.Measurements.Registration;

namespace Vantage.Measurements.Units.Force
{
    public class CompositeForce<TMass, TAccel> : IForceUnit, ICompositeUnit<TMass, TAccel>
        where TMass : class, IMassUnit
        where TAccel : class, IAccelerationUnit
    {
        private readonly Lazy<TMass> _massUnitLazy = new Lazy<TMass>(UnitRegistry.Get<TMass>());
        private readonly Lazy<TAccel> _accelerationUnitLazy = new Lazy<TAccel>(UnitRegistry.Get<TAccel>());

        private string? _symbolOverride;
        private string? _nameOverride;
        private string? _pluralNameOverride;

        public string Symbol
        {
            get => _symbolOverride ?? $"{MassUnit.Symbol}{Symbols.Dot}{AccelerationUnit.Symbol}";
            set => _symbolOverride = value;
        }

        public string Name
        {
            get => _nameOverride ?? $"{MassUnit.Name}-{AccelerationUnit.Name}";
            set => _nameOverride = value;
        }

        public string PluralName
        {
            get => _pluralNameOverride ?? Name;
            set => _pluralNameOverride = value;
        }

        public UnitSystem System => MassUnit.System & AccelerationUnit.System;

        private TMass MassUnit => _massUnitLazy.Value;

        private TAccel AccelerationUnit => _accelerationUnitLazy.Value;

        public double ToNewtons(double value) 
            => MassUnit.ToKilograms(value) * AccelerationUnit.ToMetersPerSecondSquared(1);

        public double FromNewtons(double value) 
            => MassUnit.FromKilograms(value) * AccelerationUnit.FromMetersPerSecondSquared(1);
    }

    public class CompositeForce<TMass, TLen, TTime> : IForceUnit, ICompositeUnit<TMass, TLen, TTime>
        where TMass : class, IMassUnit
        where TLen : class, ILengthUnit
        where TTime : class, ITimeUnit
    {
        private readonly Lazy<TMass> _massUnitLazy = new Lazy<TMass>(UnitRegistry.Get<TMass>());
        private readonly Lazy<TLen> _lengthUnitLazy = new Lazy<TLen>(UnitRegistry.Get<TLen>());
        private readonly Lazy<TTime> _timeUnitLazy = new Lazy<TTime>(UnitRegistry.Get<TTime>());

        private string? _symbolOverride;
        private string? _nameOverride;
        private string? _pluralNameOverride;

        public string Symbol
        {
            get => _symbolOverride ?? $"{MassUnit.Symbol}{Symbols.Dot}{LengthUnit.Symbol}/{TimeUnit.Symbol}{Symbols.Super2}";
            set => _symbolOverride = value;
        }

        public string Name
        {
            get => _nameOverride ?? $"{MassUnit.Name}-{LengthUnit.PluralName} per {TimeUnit.Name} squared";
            set => _nameOverride = value;
        }

        public string PluralName
        {
            get => _pluralNameOverride ?? Name;
            set => _pluralNameOverride = value;
        }

        public UnitSystem System => MassUnit.System & LengthUnit.System & TimeUnit.System;

        private TMass MassUnit => _massUnitLazy.Value;

        private TLen LengthUnit => _lengthUnitLazy.Value;

        private TTime TimeUnit => _timeUnitLazy.Value;

        public double ToNewtons(double value) 
            => MassUnit.ToKilograms(value) * (LengthUnit.ToMeters(1) / Math.Pow(TimeUnit.ToSeconds(1), 2));

        public double FromNewtons(double value) 
            => MassUnit.FromKilograms(value) * (LengthUnit.FromMeters(1) / Math.Pow(TimeUnit.FromSeconds(1), 2));
    }
}
