namespace Vantage.Measurements.Units.Temperature
{
    public class Celsius : ITemperatureUnit
    {
        public string Symbol { get; set; } = "\u2103";

        public string Name { get; set; } = nameof(Celsius);

        public string PluralName { get; set; } = nameof(Celsius);

        public UnitSystem System => UnitSystem.International;

        public double FromKelvin(double value)
            => value - 273.15;

        public double ToKelvin(double value)
            => value + 273.15;
    }
}