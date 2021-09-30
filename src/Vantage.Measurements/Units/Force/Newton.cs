using System;
using Vantage.Measurements.Prefixes;
using Vantage.Measurements.Units.Time;

namespace Vantage.Measurements.Units.Force
{
    public class Newton : IForceUnit
    {
        public string Symbol { get; set; } = "N";

        public string Name { get; set; } = "Newton";

        public string PluralName { get; set; } = "Newtons";

        public UnitSystem System => UnitSystem.International;

        public double ToNewtons(double value)
            => value;

        public double FromNewtons(double value)
            => value;
    }
}
