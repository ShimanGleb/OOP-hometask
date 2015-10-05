using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Physics
{
    class Acceleration:Measure
    {
        public string distanceType = "km";
        public string timeType = "h";

        public Acceleration(double value)
        {
            this.value = value;
        }        

        public static Acceleration operator +(Acceleration a1, Acceleration a2)
        {
            Acceleration a3 = new Acceleration(0);
            a3.value = a1.value + a2.value;
            return a3;
        }

        public static Acceleration operator -(Acceleration a1, Acceleration a2)
        {
            Acceleration a3 = new Acceleration(0);
            a3.value = a1.value - a2.value;
            return a3;
        }

        public static Speed operator *(Acceleration a, Time t)
        {
            Speed v = new Speed(0);
            v.distanceType = a.distanceType;
            v.timeType = a.timeType;
            Converter converter = new Converter();
            v.value = converter.ConvertToSI(a).value * converter.ConvertToSI(t).value;
            return converter.ConvertFromSI(v);
        }
    }
}
