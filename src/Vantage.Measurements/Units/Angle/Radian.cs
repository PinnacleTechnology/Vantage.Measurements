namespace Vantage.Measurements.Units.Angle
{
    public class Radian : IAngleUnit
    {
        public string Symbol { get; set; } = "rad";

        public string Name { get; set; } = "Radian";

        public string PluralName { get; set; } = "Radians";

        public UnitSystem System => UnitSystem.Universal;

        public double FromRadians(double value)
            => value;

        public double ToRadians(double value)
            => value;
    }
}