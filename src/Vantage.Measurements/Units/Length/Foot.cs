namespace Vantage.Measurements.Units.Length
{
    public class Foot : ILengthUnit
    {
        public string Symbol { get; set; } = "ft";

        public string Name { get; set; } = nameof(Foot);

        public string PluralName { get; set; } = "Feet";
        
        public UnitSystem System => UnitSystem.UsCustomary | UnitSystem.Imperial;

        public double FromMeters(double value) 
            => value / 0.3048;

        public double ToMeters(double value) 
            => value * 0.3048;
    }
}
