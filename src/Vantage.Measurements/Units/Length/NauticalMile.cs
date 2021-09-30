namespace Vantage.Measurements.Units.Length
{
    public class NauticalMile : ILengthUnit
    {
        public string Symbol { get; set; } = "nmi";
      
        public string Name { get; set; } = nameof(NauticalMile);
      
        public string PluralName { get; set; } = "Nautical Miles";
      
        public UnitSystem System => UnitSystem.International;

        public double FromMeters(double value)
            => value / 1852;

        public double ToMeters(double value)
            => value * 1852;
    }
}
