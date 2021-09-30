namespace Vantage.Measurements.Units.DigitalStorage
{
    public class Byte : IDigitalStorageUnit
    {
        public string Symbol { get; set; } = "B";
       
        public string Name { get; set; } = nameof(Byte);
       
        public string PluralName { get; set; } = $"{nameof(Byte)}s";
       
        public UnitSystem System => UnitSystem.Universal;

        public double ToBytes(double value)
            => value;

        public double FromBytes(double value)
            => value;
    }
}