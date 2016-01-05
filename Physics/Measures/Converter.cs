using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Measures
{
    public class Converter
    {
        public double ConvertTimeToSI(Time x)
        {
            double value = x.value;
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
            double value = x.value;
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

        public Distance ConvertFromSI(Distance x)
        {
            Distance newValue = new Distance(1);
            newValue.distanceType = x.distanceType;
            newValue.value = x.value / ConvertDistanceToSI(newValue);
            return newValue;
        }

        public Time ConvertToSI(Time x)
        {
            Time newValue = new Time(0);
            newValue.timeType = "s";
            newValue.value = ConvertTimeToSI(x);
            return newValue;
        }

        public Time ConvertFromSI(Time x)
        {
            Time newValue = new Time(1);
            newValue.timeType = x.timeType;
            newValue.value = x.value / ConvertTimeToSI(newValue);
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

        public Speed ConvertFromSI(Speed x)
        {
            Speed newValue = new Speed(0);
            newValue.distanceType = x.distanceType;
            newValue.timeType = x.timeType;

            Distance s = new Distance(x.value);
            s.distanceType = x.distanceType;
            s = ConvertFromSI(s);

            Time t = new Time(1);
            t.timeType = x.timeType;            
            t = ConvertFromSI(t);

            newValue.value = s.value / t.value;
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

        public Acceleration ConvertFromSI(Acceleration x)
        {
            Acceleration newValue = new Acceleration(0);
            newValue.distanceType = x.distanceType;
            newValue.timeType = x.timeType;

            Speed v = new Speed(x.value);
            v = ConvertFromSI(v);

            Time t = new Time(1);
            t.timeType = x.timeType;
            t = ConvertFromSI(t);
            newValue.value = v.value / t.value;

            return newValue;
        }
    }
}
