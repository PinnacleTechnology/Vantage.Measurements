//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Vantage.Measurements.Units.Power
//{
//    public interface IPowerUnit : IUnit
//    {
//        double ToWatts(double value);
//        double FromWatts(double value);
//    }

//    public abstract class PowerUnit : Unit, IPowerUnit
//    {
//        public override string UnitType => UnitTypes.Power;
//        protected abstract double ToWattScale { get; }

//        public double ToWatts(double value) => value * ToWattScale;
//        public double FromWatts(double value) => value / ToWattScale;
//    }
//}
