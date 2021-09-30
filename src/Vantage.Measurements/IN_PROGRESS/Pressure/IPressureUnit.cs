//namespace Vantage.Measurements.Units.Pressure
//{
//    public interface IPressureUnit : IUnit
//    {
//        double ToPascals(double value);
//        double FromPascals(double value);
//    }

//    public abstract class PressureUnit : Unit, IPressureUnit
//    {
//        public override string UnitType => UnitTypes.Pressure;
//        protected abstract double ToPascalScale { get; }

//        public double ToPascals(double value) => value * ToPascalScale;
//        public double FromPascals(double value) => value / ToPascalScale;
//    }
//}
