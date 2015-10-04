using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Physics
{
    class Converter
    {
        public double ConvertTimeToSI(Time x)
        {
            double value = 0;
            switch (x.timeType)
            {
                case ("h"): value = x.value * 3600; break;
                case ("min"): value = x.value * 60; break;
                case ("ms"): value = x.value / 100; break;
            }
            return value;
        }

        public double ConvertDistanceToSI(Distance x)
        {
            double value = 0;
            switch (x.distanceType)
            {
                case ("mile"): value = x.value * 1609.27; break;
                case ("km"): value = x.value * 1000; break;
                case ("sm"): value = x.value / 100; break;
                case ("mm"): value = x.value / 1000; break;
            }
            return value;
        }

        public Distance ConvertToSI(Distance x)
        {
            Distance newValue = new Distance(0);
            newValue.distanceType = "m";
            newValue.value = ConvertDistanceToSI(x);
            return newValue;
        }

        public Time ConvertToSI(Time x)
        {
            Time newValue = new Time(0);
            newValue.timeType = "s";
            newValue.value = ConvertTimeToSI(x);
            return newValue;
        }

        public Speed ConvertToSI(Speed x)
        {
            Speed newValue = new Speed(0);
            newValue.distanceType = "m";
            newValue.timeType = "s";

            Distance s = new Distance(x.value);
            newValue.value = ConvertDistanceToSI(s);

            Time t = new Time(1);
            t.timeType = x.timeType;

            newValue.value = newValue.value / ConvertTimeToSI(t);            
            return newValue;
        }

        public Acceleration ConvertToSI(Acceleration x)
        {
            Acceleration newValue = new Acceleration(0);
            newValue.distanceType = "m";
            newValue.timeType = "s";

            Speed v=new Speed(x.value);
            v=ConvertToSI(v);
            Time t = new Time(1);
            t.timeType = x.timeType;            
            newValue.value = v.value / ConvertTimeToSI(t);

            return newValue;
        }
    }
}
