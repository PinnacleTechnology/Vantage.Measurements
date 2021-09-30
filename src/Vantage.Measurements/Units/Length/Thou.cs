using Vantage.Measurements.Prefixes;

namespace Vantage.Measurements.Units.Length
{
    public class Thou : PrefixedLength<Milli, Inch>
    {
        protected override string DefaultName { get; } = nameof(Thou);

        protected override string DefaultSymbol { get; } = "thou";
    }
}