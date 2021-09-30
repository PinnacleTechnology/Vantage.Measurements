namespace Vantage.Measurements.Units.Temperature
{
    public class Kelvin : ITemperatureUnit
    {
        public string Symbol { get; set; } = "\u212A";
        
        public string Name { get; set; } = nameof(Kelvin);
        
        public string PluralName { get; set; } = nameof(Kelvin);
        
        public UnitSystem System => UnitSystem.International;

        public double FromKelvin(double value)
            => value;

        public double ToKelvin(double value)
            => value;
    }
}
