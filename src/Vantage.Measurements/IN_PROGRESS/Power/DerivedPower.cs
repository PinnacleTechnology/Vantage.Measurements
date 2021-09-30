//using System;
//using Vantage.Measurements.Units.Energy;
//using Vantage.Measurements.Units.Force;
//using Vantage.Measurements.Units.Length;
//using Vantage.Measurements.Units.Time;

//namespace Vantage.Measurements.Units.Power
//{
//    public class CompositePower<TEnergy, TTime> : IPowerUnit, ICompositeUnit<TEnergy, TTime>
//        where TEnergy : IEnergyUnit
//        where TTime : ITimeUnit
//    {
//        private readonly TEnergy _energyUnit;
//        private readonly TTime _timeUnit;

//        public CompositePower(TEnergy energyUnit, TTime timeUnit)
//        {
//            _energyUnit = energyUnit;
//            _timeUnit = timeUnit;
//        }

//        public string Symbol { get; set; } = $"{_energyUnit.Symbol}/{_timeUnit.Symbol}";
//        public string Name { get; set; } = $"{_energyUnit.Name} per {_timeUnit.Name}";
//        public string PluralName { get; set; } = $"{_energyUnit.PluralName} per {_timeUnit.Name}";
//        public string UnitType => UnitTypes.Power;
//        public UnitSystem System => _energyUnit.System & _timeUnit.System;

//        public double ToWatts(double value) => value * (_energyUnit.ToJoules(1) / _timeUnit.ToSeconds(1));
//        public double FromWatts(double value) => value * (_energyUnit.FromJoules(1) / _timeUnit.FromSeconds(1));
//        public string Format(double value, string format, IFormatProvider formatProvider) => $"{_energyUnit.Format(value, format, formatProvider)}/{_timeUnit.Symbol}";
//        public override string ToString() => this.Description();
//    }

//    public class CompositePower<TForce, TLength, TTime> : IPowerUnit, ICompositeUnit<TForce, TLength, TTime>
//        where TForce : IForceUnit
//        where TLength : ILengthUnit
//        where TTime : ITimeUnit
//    {
//        private readonly TForce _forceUnit;
//        private readonly TLength _lengthUnit;
//        private readonly TTime _timeUnit;

//        public CompositePower(TForce forceUnit, TLength lengthUnit, TTime timeUnit)
//        {
//            _forceUnit = forceUnit;
//            _lengthUnit = lengthUnit;
//            _timeUnit = timeUnit;
//        }

//        public string Symbol { get; set; } = $"{_forceUnit.Symbol}{Symbols.Dot}{_lengthUnit.Symbol}/{_timeUnit.Symbol}";
//        public string Name { get; set; } = $"{_forceUnit.Name} {_lengthUnit.PluralName} per {_timeUnit.Name}";
//        public string PluralName { get; set; } = Name;
//        public string UnitType => UnitTypes.Power;
//        public UnitSystem System => _forceUnit.System & _lengthUnit.System & _timeUnit.System;

//        public double ToWatts(double value) =>
//            value * ((_forceUnit.ToNewtons(1) * _lengthUnit.ToMeters(1)) / _timeUnit.ToSeconds(1));

//        public double FromWatts(double value) =>
//            value * ((_forceUnit.FromNewtons(1) * _lengthUnit.FromMeters(1)) / _timeUnit.FromSeconds(1));

//        public string Format(double value, string format, IFormatProvider formatProvider) =>
//           $"{_forceUnit.Format(value, format, formatProvider)}{Symbols.Dot}{_lengthUnit.Symbol}/{_timeUnit.Symbol}";

//        public override string ToString() => this.Description();
//    }
//}