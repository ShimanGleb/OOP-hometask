using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Physics
{
    class Time:Measure
    {        
        public string timeType = "h";
        public Time(double value)
        {
            this.value = value;
        }

        public static Time operator +(Time t1, Time t2)
        {
            Time t3 = new Time(0);
            t3.value = t1.value + t2.value;
            return t3;
        }

        public static Time operator -(Time t1, Time t2)
        {
            Time t3 = new Time(0);
            t3.value = t1.value - t2.value;
            return t3;
        }

        public static Distance operator *(Time t, Speed v)
        {
            Distance s = new Distance(0);
            s.value = v.value * t.value;
            return s;
        }

        public static Speed operator *(Time t, Acceleration a)
        {
            Speed v = new Speed(0);
            v.value = a.value * t.value;
            return v;
        }
    }
}
