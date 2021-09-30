using System;
using Microsoft.VisualBasic;
using Vantage.Measurements.Prefixes;
using Vantage.Measurements.Registration;
using Vantage.Measurements.Units;
using Vantage.Measurements.Units.Area;
using Vantage.Measurements.Units.DigitalStorage;
using Vantage.Measurements.Units.Force;
using Vantage.Measurements.Units.Length;
using Vantage.Measurements.Units.Mass;
using Vantage.Measurements.Units.Speed;
using Vantage.Measurements.Units.Time;
using Vantage.Measurements.Units.Volume;
using Xunit;

namespace Vantage.Measurements.UnitTests
{
    public class UnitTest1
    {
        public class Kilometer : PrefixedLength<Kilo, Meter>
        {

        }



        [Fact]
        public void Test1()
        {
            //UnitRegistry.Configure<Kilo, Meter>(unit => unit.Symbol = "BANANA");
            //UnitRegistry.Configure<Square<Meter>>(unit => unit.Symbol = "m^2");

            var mmm = Length.OfType<Milli, Meter>(100);
            var mega_inch = Length.OfType<Kilometer>(100);

            var nauts = mega_inch.ConvertTo<NauticalMile>();


            UnitRegistry.Add<Kilometer>();





            var thing = Length.OfType<Kilo, Kilometer>(1);


            var area = Area.OfType<Square<Meter>>(100);
            var sqMiles = Area.Square<Mile>(1);
            var hectares = sqMiles.ConvertTo<Hectare>();
            var acre = hectares.ConvertTo<Acre>();
            { }




            var volume = Volume.CubicMeters(100);
            var volume1 = volume.ConvertTo<UsGallon>();
            {

            }


            var m = Length.Meters(100);
            var km = m.ConvertTo<Kilo, Meter>();
            var mm = m.ConvertTo<Mega, Meter>();
            var tm = m.ConvertTo<Tera, Meter>();


            var asdad = Length.OfType<Centi, Meter>(100);
            var etes = asdad.ConvertTo<Deca, Foot>();


            var kmph = Speed.OfType<CompositeSpeed<PrefixedLength<Kilo, Meter>, Hour>>(80);
            var mph = kmph.ConvertTo<CompositeSpeed<Foot, Second>>();
            { }
            //var rads = Angle.Radians(Math.PI / 3);
            //var degs = Angle.Of<Degree>(60);
            //var arcsec = Angle.Of<Arcsecond>(216000);
            //var arcmin = Angle.Of<Arcminute>(3600);

            //var radians = new[]
            //{
            //    rads,
            //    degs.ConvertTo<Radian>(),
            //    arcsec.ConvertTo<Radian>(),
            //    arcmin.ConvertTo<Radian>()
            //};

            //var degrees = new[]
            //{
            //    degs,
            //    rads.ConvertTo<Degree>(),
            //    arcsec.ConvertTo<Degree>(),
            //    arcmin.ConvertTo<Degree>()
            //};

            //var arcsecs = new[]
            //{
            //    arcsec,
            //    rads.ConvertTo<Arcsecond>(),
            //    degs.ConvertTo<Arcsecond>(),
            //    arcmin.ConvertTo<Arcsecond>()
            //};

            //var arcmins = new[]
            //{
            //    arcmin,
            //    degs.ConvertTo<Arcminute>(),
            //    rads.ConvertTo<Arcminute>(),
            //    arcsec.ConvertTo<Arcminute>()
            //};

            //Assert.All(radians, angle => Assert.Equal(angle, rads));
            //Assert.All(degrees, angle => Assert.Equal(angle, degs));
            //Assert.All(arcsecs, angle => Assert.Equal(angle, arcsec));
            //Assert.All(arcmins, angle => Assert.Equal(angle, arcmin));



            var length1 = Length.Meters(400).ConvertTo<Mile>().IsGreaterThanOrEqualTo(Length.Meters(500));
            var length2 = Length.Meters(400).ConvertTo<Foot>();
            var length3 = Length.Meters(400);


        }
    }
}
