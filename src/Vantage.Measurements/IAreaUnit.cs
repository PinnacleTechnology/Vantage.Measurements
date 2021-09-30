using Vantage.Measurements.Units;

namespace Vantage.Measurements
{
    [CoreUnitType]
    public interface IAreaUnit : IUnit
    {
        double ToSquareMeters(double value);

        double FromSquareMeters(double value);
    }
}
