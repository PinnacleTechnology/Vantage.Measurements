//using System;
//using Vantage.Measurements.Units.Force;
//using Vantage.Measurements.Units.Length;

//namespace Vantage.Measurements.Units.Energy
//{
//    public class CompositeEnergy<TForce, TLength> : IEnergyUnit, ICompositeUnit<TForce, TLength>
//        where TForce : IForceUnit
//        where TLength : ILengthUnit
//    {
//        private readonly TForce _forceUnit;
//        private readonly TLength _lengthUnit;

//        public CompositeEnergy(TForce forceUnit, TLength lengthUnit)
//        {
//            _forceUnit = forceUnit;
//            _lengthUnit = lengthUnit;
//        }

//        public string Symbol { get; set; } = $"{_forceUnit.Symbol}{_lengthUnit.Symbol}";
//        public string Name { get; set; } = $"{_forceUnit.Name}-{_lengthUnit.PluralName}";
//        public string PluralName { get; set; } = Name;
//        public UnitSystem System => _forceUnit.System & _lengthUnit.System;
//        public string UnitType => UnitTypes.Energy;

//        public string Format(double value, string format, IFormatProvider formatProvider) => $"{_forceUnit.Format(value, format, formatProvider)}{Symbols.Dot}{_lengthUnit.Symbol}";
//        public double ToJoules(double value) => value * (_forceUnit.ToNewtons(1) * _lengthUnit.ToMeters(1));
//        public double FromJoules(double value) => value * (_forceUnit.FromNewtons(1) * _lengthUnit.FromMeters(1));
//        public override string ToString() => this.Description();
//    }
//}