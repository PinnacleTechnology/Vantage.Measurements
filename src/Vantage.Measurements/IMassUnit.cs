namespace Vantage.Measurements
{
    [CoreUnitType]
    public interface IMassUnit : IUnit
    {
        double ToKilograms(double value);

        double FromKilograms(double value);
    }
}