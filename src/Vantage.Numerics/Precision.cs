using System;
using System.Collections.Generic;
using System.Text;

namespace Vantage.Numerics
{
    public static class Precision
    {
        public static double Current { get; set; } = Default;

        public const double Half = 0.5;
        public const double Third = 1.0 / 3.0;
        public const double Fourth = 0.25;
        public const double Fifth = 0.2;
        public const double Sixth = 1.0 / 6.0;
        public const double Eighth = 0.125;
        public const double Tenth = 0.1;
        public const double Sixteenth = 0.0625;
        public const double ThirtySecond = 0.03125;
        public const double SixtyFourth = 0.015625;
        public const double Hundredth = 0.01;
        public const double Thousandth = 0.001;
        public const double Default = 1e-6;
    }
}
