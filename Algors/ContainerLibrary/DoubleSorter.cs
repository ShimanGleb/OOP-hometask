using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerLibrary
{
    public class DoubleSorter
    {
        public void SortByInsertion(List<DoubleContainer> array, string variableName)
        {
            for (int i = 1; i < array.Count; i++)
            {
                int j = i;

                while (j != 0 && array[j].compareValues(array[j - 1], variableName) == 1)
                {
                    DoubleContainer x = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = x;
                    j--;
                }
            }
        }

        public void SortBySelecting(List<DoubleContainer> array, string variableName)
        {
            for (int i = 0; i < array.Count - 1; i++)
            {
                DoubleContainer minElement = array[i];
                int minindex = i;
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (array[j].compareValues(minElement, variableName) == 1 || array[j].compareValues(minElement, variableName) == 0)
                    {
                        minElement = array[j];
                        minindex = j;
                    }
                }
                DoubleContainer x = array[i];
                array[i] = array[minindex];
                array[minindex] = x;
            }
        }

        public void SortByExchange(List<DoubleContainer> array, string variableName)
        {
            int l = 0;
            int r = array.Count - 1;
            int k = array.Count - 1;
            do
            {
                for (int j = r; j > l; j--)
                {
                    if (array[j - 1].compareValues(array[j], variableName) == -1)
                    {
                        DoubleContainer x = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = x;
                        k = j;
                    }
                }
                l = k;
                for (int j = l + 1; j <= r; j++)
                {
                    if (array[j - 1].compareValues(array[j], variableName) == -1)
                    {
                        DoubleContainer x = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = x;
                        k = j - 1;
                    }
                }
                r = k;
            } while (l < r);
        }
    }
}
