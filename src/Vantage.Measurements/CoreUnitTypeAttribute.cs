using System;

namespace Vantage.Measurements
{
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class CoreUnitTypeAttribute : Attribute
    {
        public CoreUnitTypeAttribute()
        {
            IsCoreUnitType = true;
        }

        public bool IsCoreUnitType { get; }
    }
}
