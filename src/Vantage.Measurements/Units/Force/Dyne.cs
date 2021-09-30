namespace Vantage.Measurements.Units.Force
{
    public class Dyne : IForceUnit
    {
        public string Symbol { get; set; } = "dyn";

        public string Name { get; set; } = "Dyne";

        public string PluralName { get; set; } = "Dyne";

        public UnitSystem System => UnitSystem.International;

        public double ToNewtons(double value)
            => value * 1e-5;

        public double FromNewtons(double value)
            => value * 1e5;
    }
}