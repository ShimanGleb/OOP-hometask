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
            Time t = new Time(2);
            Speed v = new Speed(5);
            Distance s = new Distance(10);
            Acceleration a = new Acceleration(30);
            a=converter.ConvertToSI(a);
            Console.WriteLine(a.value);
            Console.ReadLine();
        }
    }
}
