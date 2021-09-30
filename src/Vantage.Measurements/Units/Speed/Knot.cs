using System;

namespace Vantage.Measurements.Units.Speed
{
    public class Knot : ISpeedUnit
    {
        public string Symbol { get; set; } = "kn";
        
        public string Name { get; set; } = nameof(Knot);
        
        public string PluralName { get; set; } = $"{nameof(Knot)}s";
        
        public UnitSystem System => UnitSystem.International;

        public double ToMetersPerSecond(double value)
            => value * 0.51444444444;

        public double FromMetersPerSecond(double value)
            => value / 0.51444444444;
    }
}
