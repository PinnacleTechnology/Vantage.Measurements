using System;

namespace Vantage.Measurements.Units.Angle
{
    public class Arcminute : IAngleUnit
    {
        public string Symbol { get; set; } = "'";

        public string Name { get; set; } = "Arcminute";

        public string PluralName { get; set; } = "Arcminutes";

        public UnitSystem System => UnitSystem.Universal;

        public double FromRadians(double value)
            => value / (Math.PI / 10800);

        public double ToRadians(double value)
            => value * (Math.PI / 10800);
    }
}