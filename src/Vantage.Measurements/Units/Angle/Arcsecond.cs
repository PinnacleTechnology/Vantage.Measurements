using System;

namespace Vantage.Measurements.Units.Angle
{
    public class Arcsecond : IAngleUnit
    {
        public string Symbol { get; set; } = "\"";

        public string Name { get; set; } = "Arcsecond";

        public string PluralName { get; set; } = "Arcseconds";

        public UnitSystem System => UnitSystem.Universal;

        public double FromRadians(double value)
            => value / (Math.PI / 648000);

        public double ToRadians(double value)
            => value * (Math.PI / 648000);
    }
}