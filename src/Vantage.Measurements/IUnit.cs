using System;
using System.Collections.Generic;

namespace Vantage.Measurements
{
    public interface IUnit
    {
        string Symbol { get; set; }

        string Name { get; set; }

        string PluralName { get; set; }

        UnitSystem System { get; }
    }
}
