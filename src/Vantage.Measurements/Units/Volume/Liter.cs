namespace Vantage.Measurements.Units.Volume
{
    public class Liter : IVolumeUnit
    {
        public string Symbol { get; set; } = "L";
        
        public string Name { get; set; } = nameof(Liter);
        
        public string PluralName { get; set; } = $"{nameof(Liter)}s";
        
        public UnitSystem System => UnitSystem.International;

        public double ToCubicMeters(double value)
            => value * Prefixes.Milli.Data.Scale;

        public double FromCubicMeters(double value)
            => value / Prefixes.Milli.Data.Scale;
    }
}