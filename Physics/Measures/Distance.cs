using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Measures
{
    public class Distance :Measure, IMeasure
    {
        public string distanceType = "km";

        public Distance(double value)
        {
            this.value = value;
        }

        new public string GiveValueInSI()
        {
            Distance x = new Distance(value);
            x.distanceType = distanceType;
            Converter conv = new Converter();
            string message = conv.ConvertToSI(x).value + " m";
            return message;
        }

        public static Distance operator +(Distance s1, Distance s2)
        {
            Distance s3 = new Distance(0);
            s3.value = s1.value + s2.value;
            return s3;
        }

        public static Distance operator -(Distance s1, Distance s2)
        {
            Distance s3 = new Distance(0);
            s3.value = s1.value - s2.value;
            return s3;
        }

        public static Distance operator +(Distance s, int x)
        {
            Distance newS = new Distance(0);
            newS.distanceType = s.distanceType;
            newS.value = s.value + x;
            return newS;
        }

        public static Distance operator +(int x, Distance s)
        {
            Distance newS = new Distance(0);
            newS.distanceType = s.distanceType;
            newS.value = s.value + x;
            return newS;
        }

        public static Distance operator /(Distance s, int x)
        {
            Distance newS = new Distance(0);
            newS.distanceType = s.distanceType;
            newS.value = s.value / x;
            return newS;
        }

        public static Speed operator / (Distance s, Time t)
        {
            Speed v = new Speed(0);
            v.distanceType = s.distanceType;
            v.timeType = t.timeType;
            Converter converter = new Converter();
            v.value = converter.ConvertToSI(s).value / converter.ConvertToSI(t).value;

            return converter.ConvertFromSI(v);
        }
    }
}
