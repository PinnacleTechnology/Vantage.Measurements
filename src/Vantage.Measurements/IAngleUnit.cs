using Vantage.Measurements.Units;

namespace Vantage.Measurements
{
    [CoreUnitType]
    public interface IAngleUnit : IUnit
    {
        double FromRadians(double value);

        double ToRadians(double value);
    }
}