namespace Vantage.Measurements.Units.Temperature
{
    public class Fahrenheit : ITemperatureUnit
    {
        public string Symbol { get; set; } = "\u2109";

        public string Name { get; set; } = nameof(Fahrenheit);

        public string PluralName { get; set; } = nameof(Fahrenheit);

        public UnitSystem System => UnitSystem.UsCustomary | UnitSystem.Imperial;

        public double FromKelvin(double value)
            => (value * 1.8) - 459.67;

        public double ToKelvin(double value)
            => (value + 459.67) / 1.8;
    }
}