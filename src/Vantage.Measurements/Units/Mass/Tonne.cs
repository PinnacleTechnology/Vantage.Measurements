namespace Vantage.Measurements.Units.Mass
{
    public class Tonne : IMassUnit
    {
        public string Symbol { get; set; } = "t";
       
        public string Name { get; set; } = nameof(Tonne);
       
        public string PluralName { get; set; } = $"{nameof(Tonne)}s";
       
        public UnitSystem System => UnitSystem.International;

        public double ToKilograms(double value)
            => value * Prefixes.Kilo.Data.Scale;

        public double FromKilograms(double value)
            => value / Prefixes.Kilo.Data.Scale;
    }

    public class MetricTon : Tonne { }
}