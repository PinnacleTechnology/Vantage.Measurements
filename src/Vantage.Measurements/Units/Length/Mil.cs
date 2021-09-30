using Vantage.Measurements.Prefixes;

namespace Vantage.Measurements.Units.Length
{
    public class Mil : PrefixedLength<Milli, Inch>
    {
        protected override string DefaultName { get; } = nameof(Mil);

        protected override string DefaultSymbol { get; } = "mil";
    }
}
