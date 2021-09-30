using System;
using System.Collections.Generic;
using System.Text;
using Vantage.Measurements.Registration;

namespace Vantage.Measurements.Units.Speed
{
    public class SpeedUnit
    {
        private readonly ILengthUnit _length;

        private SpeedUnit(ILengthUnit length)
        {
            _length = length;
        }

        public static SpeedUnit Of<T>() where T : class, ILengthUnit
            => new SpeedUnit(UnitRegistry.Get<T>());

        public ISpeedUnit Per<T>() where T : class, ITimeUnit
            => new CompositeSpeed(_length, UnitRegistry.Get<T>());
    }
}
