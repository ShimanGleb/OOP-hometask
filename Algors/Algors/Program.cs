using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContainerLibrary;

namespace Algors
{
    class Program
    {        
        static void Main(string[] args)
        {
            int size = 10;
            List<AbstractStringContainer> array = new List<AbstractStringContainer>();
            for (int i = 0; i < size; i++)
            {
                StringContainer item = new StringContainer(i);
                array.Add(item);
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i].ReturnValue("value1") + " ");
            }
            Console.WriteLine();

            StringSorter sorter = new StringSorter();
            sorter.SortByExchange(array, "value1");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i].ReturnValue("value1") + " ");                
            }            
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
