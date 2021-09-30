namespace Vantage.Measurements.Units.Time
{
    public class Week : ITimeUnit
    {
        public string Symbol { get; set; } = "week";
       
        public string Name { get; set; } = nameof(Week);
       
        public string PluralName { get; set; } = $"{nameof(Week)}s";
       
        public UnitSystem System => UnitSystem.Universal;

        public double ToSeconds(double value)
            => value * 604800;

        public double FromSeconds(double value)
            => value / 604800;
    }
}