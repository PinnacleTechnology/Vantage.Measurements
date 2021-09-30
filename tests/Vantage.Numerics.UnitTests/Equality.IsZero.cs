using System;
using Xunit;

namespace Vantage.Numerics.UnitTests
{
    public class IsZero
    {
        [InlineData(0, true)]
        [InlineData(0.000, true)]
        [InlineData(0.000001, true)]
        [InlineData(-0.000001, true)]
        [InlineData(1, false)]
        [InlineData(0.01, false)]
        [InlineData(0.0001, false)]
        [InlineData(0.00001, false)]
        [InlineData(-0.00001, false)]
        [Theory]
        public void DefaultPrecision_Double(double value, bool isZero)
        {
            Assert.Equal(value.IsZero(), isZero);
        }

        [InlineData(0, true)]
        [InlineData(0.000, true)]
        [InlineData(0.000001, true)]
        [InlineData(-0.000001, true)]
        [InlineData(1, false)]
        [InlineData(0.01, false)]
        [InlineData(0.0001, false)]
        [InlineData(0.00001, false)]
        [InlineData(-0.00001, false)]
        [Theory]
        public void DefaultPrecision_Float(float value, bool isZero)
        {
            Assert.Equal(value.IsZero(), isZero);
        }

        [InlineData(0, true)]
        [InlineData(0.000, true)]
        [InlineData(0.000001, true)]
        [InlineData(-0.000001, true)]
        [InlineData(1, false)]
        [InlineData(0.01, false)]
        [InlineData(0.0001, false)]
        [InlineData(0.00001, false)]
        [InlineData(-0.00001, false)]
        [Theory]
        public void DefaultPrecision_Decimal(decimal value, bool isZero)
        {
            Assert.Equal(value.IsZero(), isZero);
        }

        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(-1, false)]
        [Theory]
        public void DefaultPrecision_Int(int value, bool isZero)
        {
            Assert.Equal(value.IsZero(), isZero);
        }

        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(-1, false)]
        [Theory]
        public void DefaultPrecision_Long(long value, bool isZero)
        {
            Assert.Equal(value.IsZero(), isZero);
        }
    }
}
