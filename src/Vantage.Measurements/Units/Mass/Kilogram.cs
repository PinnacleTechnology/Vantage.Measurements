namespace Vantage.Measurements.Units.Mass
{
    public class Kilogram : IMassUnit
    {
        public string Symbol { get; set; } = "kg";
        
        public string Name { get; set; } = nameof(Kilogram);
        
        public string PluralName { get; set; } = $"{nameof(Kilogram)}s";
        
        public UnitSystem System => UnitSystem.International;

        public double ToKilograms(double value)
            => value;

        public double FromKilograms(double value)
            => value;
    }
}