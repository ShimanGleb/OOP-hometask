using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Measures
{
    public class SquireTime :Measure
    {
        public string timeType = "h";

        public SquireTime(double value)
        {
            this.value = value;
        }

        public static SquireTime operator +(SquireTime t1, SquireTime t2)
        {
            SquireTime t3 = new SquireTime(0);
            t3.value = t1.value + t2.value;
            return t3;
        }

        public static SquireTime operator -(SquireTime t1, SquireTime t2)
        {
            SquireTime t3 = new SquireTime(0);
            t3.value = t1.value - t2.value;
            return t3;
        }

        public static Distance operator *(SquireTime tt, Acceleration a)
        {
            Distance s = new Distance(0);
            s.distanceType = a.distanceType;            
            s.value =  tt.value * a.value;
            return s;
        }
    }
}
