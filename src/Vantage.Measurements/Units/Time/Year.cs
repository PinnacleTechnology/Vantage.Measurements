namespace Vantage.Measurements.Units.Time
{
    public class Year : ITimeUnit
    {
        public string Symbol { get; set; } = "a";
      
        public string Name { get; set; } = nameof(Year);
      
        public string PluralName { get; set; } = $"{nameof(Year)}s";
      
        public UnitSystem System => UnitSystem.Universal;

        public double ToSeconds(double value)
            => value * 31556952;

        public double FromSeconds(double value)
            => value / 31556952;
    }
}