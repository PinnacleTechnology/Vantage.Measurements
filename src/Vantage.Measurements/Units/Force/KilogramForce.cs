namespace Vantage.Measurements.Units.Force
{
    public class KilogramForce : IForceUnit
    {
        public string Symbol { get; set; } = "kp";

        public string Name { get; set; } = "Kilogram-Force";

        public string PluralName { get; set; } = "Kilograms-Force";

        public UnitSystem System => UnitSystem.International;

        public double ToNewtons(double value)
            => value * 9.80665;

        public double FromNewtons(double value)
            => value / 9.80665;
    }
}