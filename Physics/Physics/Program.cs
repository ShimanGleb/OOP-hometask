using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Physics
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            Time t = new Time(5);
            Speed v = new Speed(10);
            Distance s = new Distance(10);
            Acceleration a = new Acceleration(2);
            v = s / t;
            Console.WriteLine(v.value);
            Console.ReadLine();
        }
    }
}
