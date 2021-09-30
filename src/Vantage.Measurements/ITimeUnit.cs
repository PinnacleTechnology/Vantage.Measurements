namespace Vantage.Measurements
{
    [CoreUnitType]
    public interface ITimeUnit : IUnit
    {
        double FromSeconds(double value);

        double ToSeconds(double value);
    }
}