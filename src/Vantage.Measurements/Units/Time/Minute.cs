namespace Vantage.Measurements.Units.Time
{
    public class Minute : ITimeUnit
    {
        public string Symbol { get; set; } = "min";
        
        public string Name { get; set; } = nameof(Minute);
        
        public string PluralName { get; set; } = $"{nameof(Minute)}s";
        
        public UnitSystem System => UnitSystem.Universal;

        public double ToSeconds(double value)
            => value * 60;

        public double FromSeconds(double value)
            => value / 60;
    }
}