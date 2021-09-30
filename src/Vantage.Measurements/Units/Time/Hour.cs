namespace Vantage.Measurements.Units.Time
{
    public class Hour : ITimeUnit
    {
        public string Symbol { get; set; } = "h";
        
        public string Name { get; set; } = nameof(Hour);
        
        public string PluralName { get; set; } = $"{nameof(Hour)}s";
        
        public UnitSystem System => UnitSystem.Universal;

        public double ToSeconds(double value)
            => value * 3600;

        public double FromSeconds(double value)
            => value / 3600;
    }
}
