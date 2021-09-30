namespace Vantage.Measurements.Units.Mass
{
    public class Ounce : IMassUnit
    {
        public string Symbol { get; set; } = "oz";
    
        public string Name { get; set; } = nameof(Ounce);
    
        public string PluralName { get; set; } = $"{nameof(Ounce)}s";
    
        public UnitSystem System => UnitSystem.UsCustomary | UnitSystem.Imperial;

        public double ToKilograms(double value)
            => value * 0.0283495;

        public double FromKilograms(double value)
            => value / 0.0283495;
    }
}