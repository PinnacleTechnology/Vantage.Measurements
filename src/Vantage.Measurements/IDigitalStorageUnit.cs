namespace Vantage.Measurements
{
    [CoreUnitType]
    public interface IDigitalStorageUnit : IUnit
    {
        double ToBytes(double value);

        double FromBytes(double value);
    }
}
