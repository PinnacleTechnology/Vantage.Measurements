namespace Vantage.Measurements
{
    [CoreUnitType]
    public interface ITemperatureUnit : IUnit
    {
        double FromKelvin(double value);

        double ToKelvin(double value);
    }
}
