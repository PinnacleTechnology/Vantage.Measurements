namespace Vantage.Measurements.Units.Force
{
    public class Kip : IForceUnit
    {
        public string Symbol { get; set; } = "kip";

        public string Name { get; set; } = "Kip";

        public string PluralName { get; set; } = "Kips";

        public UnitSystem System => UnitSystem.UsCustomary;

        public double ToNewtons(double value)
            => value * 4448.2216;

        public double FromNewtons(double value)
            => value / 4448.2216;
    }
}