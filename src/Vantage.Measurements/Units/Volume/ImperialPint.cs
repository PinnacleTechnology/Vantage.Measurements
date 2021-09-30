namespace Vantage.Measurements.Units.Volume
{
    public class ImperialPint : IVolumeUnit
    {
        public string Symbol { get; set; } = "pt (imp)";
       
        public string Name { get; set; } = "Imperial Pint";
       
        public string PluralName { get; set; } = "Imperial Pints";
       
        public UnitSystem System => UnitSystem.Imperial;

        public double ToCubicMeters(double value)
            => value * 0.56826125e-3;

        public double FromCubicMeters(double value)
            => value / 0.56826125e-3;
    }
}