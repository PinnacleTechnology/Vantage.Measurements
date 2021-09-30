namespace Vantage.Measurements.Units.Volume
{
    public class UsFluidOunce : IVolumeUnit
    {
        public string Symbol { get; set; } = "fl oz (US)";
       
        public string Name { get; set; } = "US Fluid Ounce";
       
        public string PluralName { get; set; } = "US Fluid Ounces";
       
        public UnitSystem System => UnitSystem.UsCustomary;

        public double ToCubicMeters(double value)
            => value * 29.5735295625e-6;

        public double FromCubicMeters(double value)
            => value / 29.5735295625e-6;
    }
}
