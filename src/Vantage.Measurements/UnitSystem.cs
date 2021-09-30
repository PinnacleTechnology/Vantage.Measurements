using System;
using System.ComponentModel;

namespace Vantage.Measurements
{
    [Flags]
    public enum UnitSystem
    {
        None = 0,
        [Description("International System (SI)")]
        International = 1,
        [Description("United States Customary System (USCS)")]
        UsCustomary = 2,
        [Description("British Imperial System")]
        Imperial = 4,
        Universal = International + UsCustomary + Imperial
    }
}