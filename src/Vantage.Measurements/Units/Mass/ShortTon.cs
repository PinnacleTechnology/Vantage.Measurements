namespace Vantage.Measurements.Units.Mass
{
    public class ShortTon : IMassUnit
    {
        public string Symbol { get; set; } = "ton (US)";

        public string Name { get; set; } = "Ton (US)";

        public string PluralName { get; set; } = "Tons (US)";

        public UnitSystem System => UnitSystem.UsCustomary;

        public double ToKilograms(double value)
            => value * 907.1847;

        public double FromKilograms(double value)
            => value / 907.1847;
    }

    public class UsTon : ShortTon { }
}