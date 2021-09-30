using Vantage.Measurements.Units;

namespace Vantage.Measurements
{
    [CoreUnitType]
    public interface IAccelerationUnit : IUnit
    {
        double ToMetersPerSecondSquared(double value);

        double FromMetersPerSecondSquared(double value);
    }
}
