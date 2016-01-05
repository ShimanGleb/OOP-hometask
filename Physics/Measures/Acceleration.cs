using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Measures
{
    public class Acceleration:Measure
    {
        public string distanceType = "km";
        public string timeType = "h";

        public Acceleration(double value)
        {
            this.value = value;
        }

        public string GiveValueInSI()
        {
            Acceleration x = new Acceleration(value);
            x.distanceType = distanceType;
            x.timeType = timeType;
            Converter conv = new Converter();
            string message = conv.ConvertToSI(x).value + " m/(s^2)";
            return message;
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

        public static Distance operator *(Acceleration a, SquireTime tt)
        {
            Distance s = new Distance(0);
            s.distanceType = a.distanceType;
            s.value = tt.value * a.value;
            return s;
        }
    }
}
