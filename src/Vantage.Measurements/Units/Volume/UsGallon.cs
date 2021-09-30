namespace Vantage.Measurements.Units.Volume
{
    public class UsGallon : IVolumeUnit
    {
        public string Symbol { get; set; } = "gal (US)";
       
        public string Name { get; set; } = "US Liquid Gallon";
       
        public string PluralName { get; set; } = "US Liquid Gallons";
       
        public UnitSystem System => UnitSystem.UsCustomary;

        public double ToCubicMeters(double value)
            => value * 3.785411784e-3;

        public double FromCubicMeters(double value)
            => value / 3.785411784e-3;
    }
}
