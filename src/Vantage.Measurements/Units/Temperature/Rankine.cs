namespace Vantage.Measurements.Units.Temperature
{
    public class Rankine : ITemperatureUnit
    {
        public string Symbol { get; set; } = "R";
        
        public string Name { get; set; } = nameof(Rankine);
        
        public string PluralName { get; set; } = nameof(Rankine);
        
        public UnitSystem System => UnitSystem.UsCustomary | UnitSystem.Imperial;

        public double FromKelvin(double value)
            => value * 1.8;

        public double ToKelvin(double value)
            => value / 1.8;
    }
}