using System;

namespace Vantage.Measurements.Units.Acceleration
{
    public class StandardGravity : IAccelerationUnit
    {
        public string Symbol { get; set; } = "ɡ0";
        
        public string Name { get; set; } = "Standard Gravity";
        
        public string PluralName { get; set; } = "Standard Gravity";
        
        public UnitSystem System => UnitSystem.International;
      
        public double ToMetersPerSecondSquared(double value)
            => value * 9.80665;

        public double FromMetersPerSecondSquared(double value)
            => value / 9.80665;
    }
}
