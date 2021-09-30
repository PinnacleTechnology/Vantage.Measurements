namespace Vantage.Measurements.Units.Mass
{
    public class Pound : IMassUnit
    {
        public string Symbol { get; set; } = "lb";
        
        public string Name { get; set; } = nameof(Pound);
        
        public string PluralName { get; set; } = $"{nameof(Pound)}s";
        
        public UnitSystem System => UnitSystem.UsCustomary | UnitSystem.Imperial;

        public double ToKilograms(double value)
            => value * 0.45359237;

        public double FromKilograms(double value)
            => value / 0.45359237;
    }
}
