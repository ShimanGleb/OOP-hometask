using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Measures;

namespace Physics
{
    class Program
    {
        static void Main(string[] args)
        {            
            Time t = new Time(5);
            Speed v = new Speed(10);
            Distance s = new Distance(10);
            Acceleration a = new Acceleration(3);
            s = 2 + (a * (t^2)) / 2;
            Converter conv = new Converter();
            Console.WriteLine(a.GiveValueInSI());
            Console.ReadLine();
        }
    }
}
