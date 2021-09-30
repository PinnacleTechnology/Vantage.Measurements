namespace Vantage.Measurements.Units.Length
{
    public class Inch : ILengthUnit
    {
        public string Symbol { get; set; } = "in";

        public string Name { get; set; } = nameof(Inch);

        public string PluralName { get; set; } = "Inches";
        
        public UnitSystem System => UnitSystem.UsCustomary | UnitSystem.Imperial;

        public double FromMeters(double value) 
            => value / 0.0254;

        public double ToMeters(double value) 
            => value * 0.0254;
    }
}