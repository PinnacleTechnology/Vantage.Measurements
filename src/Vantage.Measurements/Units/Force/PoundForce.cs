using System;

namespace Vantage.Measurements.Units.Force
{
    public class PoundForce : IForceUnit
    {
        public string Symbol { get; set; } = "lbf";

        public string Name { get; set; } = "Pound-force";

        public string PluralName { get; set; } = "Pounds-force";

        public UnitSystem System => UnitSystem.UsCustomary | UnitSystem.Imperial;

        public double ToNewtons(double value)
            => value * 4.4482216;

        public double FromNewtons(double value)
            => value / 4.4482216;
    }
}
