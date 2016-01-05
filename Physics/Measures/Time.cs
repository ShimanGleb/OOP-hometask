using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Measures
{
    public class Time:Measure, IMeasure
    {        
        public string timeType = "h";
        
        public Time(double value)
        {
            this.value = value;
        }

        new public string GiveValueInSI()
        {            
            Time x = new Time(value);
            x.timeType = timeType;
            Converter conv = new Converter();
            string message = conv.ConvertToSI(x).value + " s";
            return message;
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

        public static SquireTime operator ^(Time t, int x = 2)
        {
            SquireTime newT = new SquireTime(0);
            newT.timeType = t.timeType;
            newT.value = t.value * t.value;
            return newT;
        }

        public static Distance operator *(Time t, Speed v)
        {
            Distance s = new Distance(0);
            s.distanceType = v.distanceType;
            Converter converter = new Converter();
            s.value = converter.ConvertToSI(v).value * converter.ConvertToSI(t).value;
            return converter.ConvertFromSI(s);
        }

        public static Speed operator *(Time t, Acceleration a)
        {
            Speed v = new Speed(0);
            v.distanceType = a.distanceType;
            Converter converter = new Converter();
            v.value = converter.ConvertToSI(a).value * converter.ConvertToSI(t).value;
            return converter.ConvertFromSI(v);
        }
    }
}
