using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContainerLibrary;

namespace Algors
{
    class Program
    {
        /*public static void SortByInsertion(List<DefaultContainer> array)
        {                        
            for (int i = 1; i < array.Count; i++)
            {
                int j = i;
                
                while (j != 0 && array[j] < array[j - 1])
                {
                    DefaultContainer x = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = x;
                    j--;                    
                }
            }
        }

        public static void SortBySelecting(List<DefaultContainer> array)
        {
            for (int i = 0; i < array.Count - 1; i++)
            {
                DefaultContainer minElement = array[i];
                int minindex = i;
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (array[j] <= minElement)
                    {
                        minElement = array[j];
                        minindex = j;
                    }                    
                }
                DefaultContainer x = array[i];
                array[i] = array[minindex];
                array[minindex] = x;                
            }
        }

        public static void SortByExchange(List<DefaultContainer> array)
        {
            int l = 0;
            int r = array.Count - 1;
            int k = array.Count - 1;
            do
            {
                for (int j = r; j > l; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        DefaultContainer x = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = x;
                        k = j;                        
                    }                    
                }
                l = k;
                for (int j = l + 1; j <= r; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        DefaultContainer x = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = x;
                        k = j - 1;                        
                    }                    
                }
                r = k;
            } while (l < r);
        }*/

        static void Main(string[] args)
        {
            int size = 10;
            List<StringContainer> array = new List<StringContainer>();
            for (int i = 0; i < size; i++)
            {
                StringContainer item = new StringContainer(i * (-1));
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
