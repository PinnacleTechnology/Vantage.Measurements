namespace Vantage.Measurements
{
    public interface IMeasurement
    {
        double Value { get; }
        IUnit Unit { get; }
    }

    public interface IMeasurement<out T> : IMeasurement where T : IUnit
    {
        new T Unit { get; }
    }
}
