namespace Vantage.Measurements.Units.Time
{
    public class LunarMonth : ITimeUnit
    {
        public string Symbol { get; set; } = "lunar month";
        
        public string Name { get; set; } = "Lunar Month";
        
        public string PluralName { get; set; } = "Lunar Months";
        
        public UnitSystem System => UnitSystem.Universal;

        public double ToSeconds(double value)
            => value * 2551442.8032;

        public double FromSeconds(double value)
            => value / 2551442.8032;
    }
}