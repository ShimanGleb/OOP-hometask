using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Physics
{
    class Speed:Measure
    {
        public string distanceType = "km";
        public string timeType = "h";

        public Speed(double value)
        {
            this.value = value;
        }

        public static Speed operator +(Speed v1, Speed v2)
        {
            Speed v3 = new Speed(0);
            v3.value = v1.value + v2.value;
            return v3;
        }

        public static Speed operator -(Speed v1, Speed v2)
        {
            Speed v3 = new Speed(0);
            v3.value = v1.value - v2.value;
            return v3;
        }

        public static Distance operator * (Speed v, Time t)
        {
            Distance s = new Distance(0);
            s.value = v.value * t.value;
            return s;
        }

        public static Time operator /(Distance s, Speed v)
        {
            Time t = new Time(0);
            t.value = s.value / s.value;
            return t;
        }

        public static Time operator /(Speed v, Acceleration a)
        {
            Time t = new Time(0);
            t.value = v.value / a.value;
            return t;
        }

        public static Acceleration operator /(Speed v, Time t)
        {
            Acceleration a = new Acceleration(0);
            a.value = v.value / t.value;
            return a;
        }
    }
}
