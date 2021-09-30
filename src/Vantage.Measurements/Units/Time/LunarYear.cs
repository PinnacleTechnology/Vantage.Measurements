namespace Vantage.Measurements.Units.Time
{
    public class LunarYear : ITimeUnit
    {
        public string Symbol { get; set; } = "lunar year";
        
        public string Name { get; set; } = "Lunar Year";
        
        public string PluralName { get; set; } = "Lunar Years";
        
        public UnitSystem System => UnitSystem.Universal;

        public double ToSeconds(double value)
            => value * 30617313.6384;

        public double FromSeconds(double value)
            => value / 30617313.6384;
    }
}