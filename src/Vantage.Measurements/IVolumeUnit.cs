namespace Vantage.Measurements
{
    [CoreUnitType]
    public interface IVolumeUnit : IUnit
    {
        double ToCubicMeters(double value);

        double FromCubicMeters(double value);
    }
}
