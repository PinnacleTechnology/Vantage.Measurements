//using Vantage.Measurements.Units.Energy;
//using Vantage.Measurements.Units.Power;
//using Vantage.Measurements.Units.Time;
//using Vantage.Measurements.Units.Volume;

//namespace Vantage.Measurements
//{
//    public static partial class MeasurementExtensions
//    {
//        public static Power To<T>(this Power measurement) where T : IPowerUnit
//        {
//            var unit = UnitRegistry.GetUnit<T>();
//            return measurement.To(unit);
//        }

//        public static Power To<TEnergy, TTIme>(this Power measurement) where TEnergy:IEnergyUnit where TTIme:ITimeUnit
//        {
//            var unit = UnitRegistry.GetUnit<CompositePower<TEnergy, TTIme>>();
//            return measurement.To(unit);
//        }

//        public static Power To(this Power measurement, IPowerUnit unit)
//        {
//            var baseValue = measurement.Unit.ToWatts(measurement.Value);
//            return new Power(unit.FromWatts(baseValue), unit);
//        }
//    }
//}