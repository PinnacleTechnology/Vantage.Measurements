namespace Vantage.Measurements.Units.Volume
{
    public class ImperialQuart : IVolumeUnit
    {
        public string Symbol { get; set; } = "qt (imp)";
        
        public string Name { get; set; } = "Imperial Quart";
        
        public string PluralName { get; set; } = "Imperial Quarts";
        
        public UnitSystem System => UnitSystem.Imperial;

        public double ToCubicMeters(double value)
            => value * 1.1365225e-3;

        public double FromCubicMeters(double value)
            => value / 1.1365225e-3;
    }
}