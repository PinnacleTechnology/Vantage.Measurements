namespace Vantage.Measurements.Units.Volume
{
    public class UsPint : IVolumeUnit
    {
        public string Symbol { get; set; } = "pt (US)";
        
        public string Name { get; set; } = "US Liquid Pint";
        
        public string PluralName { get; set; } = "US Liquid Pints";
        
        public UnitSystem System => UnitSystem.UsCustomary;

        public double ToCubicMeters(double value)
            => value * 0.473176473e-3;

        public double FromCubicMeters(double value)
            => value / 0.473176473e-3;
    }
}