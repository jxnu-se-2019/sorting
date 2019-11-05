using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Jianglinhai
{
    class LTQuickSorter : SorterBase

    {
        public override void Sort(int[] b)
        {
            if (b == null)
            {
                return;
            }
            static int sortUnit(int[] array, int low, int high)
            {
                int key = array[low];
                while (low < high)
                {
                    while (array[high] >= key && high > low)
                        --high;

                    array[low] = array[high];

                    while (array[low] <= key && high > low)
                        ++low;

                    array[high] = array[low];
                }

                array[low] = key;
                foreach (int i in array)
                {
                    Console.Write("{0}\t", i);
                }
                Console.WriteLine();
                return high;
            }


            static void sort(int[] array, int low, int high)
            {
                if (low >= high)
                    return;
                int index = sortUnit(array, low, high);

                sort(array, low, index - 1);

                sort(array, index + 1, high);
            }


        }



    }
}

