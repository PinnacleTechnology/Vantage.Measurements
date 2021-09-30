namespace Vantage.Measurements.Units.Mass
{
    public class Stone : IMassUnit
    {
        public string Symbol { get; set; } = "st.";
     
        public string Name { get; set; } = nameof(Stone);
     
        public string PluralName { get; set; } = nameof(Stone);
     
        public UnitSystem System => UnitSystem.Imperial;

        public double ToKilograms(double value)
            => value * 6.35029318;

        public double FromKilograms(double value)
            => value / 6.35029318;
    }
}