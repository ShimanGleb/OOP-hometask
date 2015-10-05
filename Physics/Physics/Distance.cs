using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Physics
{
    class Distance:Measure
    {
        public string distanceType = "km";

        public Distance(double value)
        {
            this.value = value;
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
