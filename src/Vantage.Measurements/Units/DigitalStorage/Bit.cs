namespace Vantage.Measurements.Units.DigitalStorage
{
    public class Bit : IDigitalStorageUnit
    {
        public string Symbol { get; set; } = "bit";
    
        public string Name { get; set; } = nameof(Bit);
    
        public string PluralName { get; set; } = $"{nameof(Bit)}s";
    
        public UnitSystem System => UnitSystem.Universal;

        public double ToBytes(double value)
            => value * 8;

        public double FromBytes(double value)
            => value / 8;
    }
}