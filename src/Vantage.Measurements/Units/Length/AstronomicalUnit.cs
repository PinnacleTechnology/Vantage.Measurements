namespace Vantage.Measurements.Units.Length
{
    public class AstronomicalUnit : ILengthUnit
    {
        public string Symbol { get; set; } = "au";

        public string Name { get; set; } = "Astronomical Unit";

        public string PluralName { get; set; } = "Astronomical Units";
      
        public UnitSystem System => UnitSystem.Universal;

        public double FromMeters(double value) => 
            value / 149597870700;

        public double ToMeters(double value) 
            => value * 149597870700;
    }
}
