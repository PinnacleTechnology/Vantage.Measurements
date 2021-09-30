namespace Vantage.Measurements.Units.Volume
{
    public class UsQuart : IVolumeUnit
    {
        public string Symbol { get; set; } = "qt (US)";

        public string Name { get; set; } = "US Liquid Quart";

        public string PluralName { get; set; } = "US Liquid Quarts";

        public UnitSystem System => UnitSystem.UsCustomary;

        public double ToCubicMeters(double value)
            => value * 0.946352946e-3;

        public double FromCubicMeters(double value)
            => value / 0.946352946e-3;
    }
}