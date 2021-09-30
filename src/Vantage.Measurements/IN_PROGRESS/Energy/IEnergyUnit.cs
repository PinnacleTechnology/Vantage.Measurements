//namespace Vantage.Measurements.Units.Energy
//{
//    public interface IEnergyUnit : IUnit
//    {
//        double ToJoules(double value);
//        double FromJoules(double value);
//    }

//    public abstract class EnergyUnit : Unit, IEnergyUnit
//    {
//        public override string UnitType => UnitTypes.Energy;
//        protected abstract double ToJouleScale { get; }

//        public double ToJoules(double value) => value * ToJouleScale;
//        public double FromJoules(double value) => value / ToJouleScale;
//    }
//}
