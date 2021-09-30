namespace Vantage.Measurements
{
    [CoreUnitType]
    public interface IForceUnit : IUnit
    {
        double ToNewtons(double value);

        double FromNewtons(double value);
    }
}
