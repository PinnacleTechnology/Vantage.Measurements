namespace Vantage.Measurements
{
    [CoreUnitType]
    public interface ISpeedUnit : IUnit
    {
        double ToMetersPerSecond(double value);

        double FromMetersPerSecond(double value);
    }
}
