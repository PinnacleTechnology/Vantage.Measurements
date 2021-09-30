namespace Vantage.Measurements.Units.Volume
{
    public class ImperialFluidOunce : IVolumeUnit
    {
        public string Symbol { get; set; } = "fl oz (imp)";
        
        public string Name { get; set; } = "Imperial Fluid Ounce";
        
        public string PluralName { get; set; } = "Imperial Fluid Ounces";
        
        public UnitSystem System => UnitSystem.Imperial;

        public double ToCubicMeters(double value)
            => value * 28.4130625e-6;

        public double FromCubicMeters(double value)
            => value / 28.4130625e-6;
    }
}