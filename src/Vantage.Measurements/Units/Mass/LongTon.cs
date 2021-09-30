namespace Vantage.Measurements.Units.Mass
{
    public class LongTon : IMassUnit
    {
        public string Symbol { get; set; } = "ton (UK)";
        
        public string Name { get; set; } = "Imperial Ton";
        
        public string PluralName { get; set; } = "Imperial Tons";
        
        public UnitSystem System => UnitSystem.Imperial;

        public double ToKilograms(double value)
            => value * 1016.047;

        public double FromKilograms(double value)
            => value / 1016.047;
    }

    public class ImperialTon : LongTon { }

    public class UkTon : LongTon { }
}