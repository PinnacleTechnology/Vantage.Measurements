namespace Vantage.Measurements.Units.Area
{
    public class Acre : IAreaUnit
    {
        public string Symbol { get; set; } = "ac";
        
        public string Name { get; set; } = nameof(Acre);
        
        public string PluralName { get; set; } = $"{nameof(Acre)}s";
        
        public UnitSystem System => UnitSystem.UsCustomary;

        public double ToSquareMeters(double value) 
            => value * 4046.8564224;

        public double FromSquareMeters(double value)
            => value / 4046.8564224;
    }
}