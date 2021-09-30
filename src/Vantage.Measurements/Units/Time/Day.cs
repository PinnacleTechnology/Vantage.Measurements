namespace Vantage.Measurements.Units.Time
{
    public class Day : ITimeUnit
    {
        public string Symbol { get; set; } = "d";
        
        public string Name { get; set; } = nameof(Day);
        
        public string PluralName { get; set; } = $"{nameof(Day)}s";
        
        public UnitSystem System => UnitSystem.Universal;

        public double ToSeconds(double value)
            => value * 86400;

        public double FromSeconds(double value)
            => value / 86400;
    }
}