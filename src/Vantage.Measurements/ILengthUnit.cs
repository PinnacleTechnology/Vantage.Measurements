namespace Vantage.Measurements
{
    [CoreUnitType]
    public interface ILengthUnit : IUnit
    {
        double FromMeters(double value);

        double ToMeters(double value);
    }
}