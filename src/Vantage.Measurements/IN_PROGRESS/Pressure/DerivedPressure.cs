//using System;
//using Vantage.Measurements.Units;
//using Vantage.Measurements.Units.Area;
//using Vantage.Measurements.Units.Force;

//namespace Vantage.Measurements.Units.Pressure
//{
//    public class CompositePressure<TForce, TArea> : IPressureUnit, ICompositeUnit<TForce, TArea>
//        where TForce : IForceUnit
//        where TArea : IAreaUnit
//    {
//        private readonly TForce _forceUnit;
//        private readonly TArea _areaUnit;

//        public CompositePressure(TForce forceUnit, TArea areaUnit)
//        {
//            _forceUnit = forceUnit;
//            _areaUnit = areaUnit;
//        }

//        public string Symbol { get; set; } = $"{_forceUnit.Symbol}/{_areaUnit.Symbol}";
//        public string Name { get; set; } = $"{_forceUnit.PluralName} per {_areaUnit.Name}";
//        public string PluralName { get; set; } = Name;
//        public string UnitType => UnitTypes.Pressure;
//        public UnitSystem System => _forceUnit.System & _areaUnit.System;

//        public string Format(double value, string format, IFormatProvider formatProvider) => $"{_forceUnit.Format(value, format, formatProvider)}/{_areaUnit.Symbol}";
//        public double ToPascals(double value) => value * (_forceUnit.ToNewtons(1) / _areaUnit.ToSquareMeters(1));
//        public double FromPascals(double value) => value * (_forceUnit.FromNewtons(1) / _areaUnit.FromSquareMeters(1));
//        public override string ToString() => this.Description();
//    }
//}