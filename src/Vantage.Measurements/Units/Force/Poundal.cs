namespace Vantage.Measurements.Units.Force
{
    public class Poundal : IForceUnit
    {
        public string Symbol { get; set; } = "pdl";

        public string Name { get; set; } = "Poundal";

        public string PluralName { get; set; } = "Poundal";

        public UnitSystem System => UnitSystem.Imperial;

        public double ToNewtons(double value)
            => value * 0.138255;

        public double FromNewtons(double value)
            => value / 0.138255;
    }
}