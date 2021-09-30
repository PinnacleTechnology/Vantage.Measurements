using System;

namespace Vantage.Measurements.Units.Angle
{
    public class Degree : IAngleUnit
    {
        public string Symbol { get; set; } = "°";

        public string Name { get; set; } = "Degree";

        public string PluralName { get; set; } = "Degrees";

        public UnitSystem System => UnitSystem.Universal;

        public double FromRadians(double value) 
            => value * (180 / Math.PI);

        public double ToRadians(double value) 
            => value * (Math.PI / 180);
    }
}