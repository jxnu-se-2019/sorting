using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Wuqi
{
    public class WYCQuickSort : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            Sort(input, 0, input.Length - 1);
        }
        public static void Sort(int[] array, int low, int high)
        {
            if (low >= high)
                return;
            int index = SortUnit(array, low, high);
            Sort(array, low, index - 1);
            Sort(array, index + 1, high);
        }
        public static int SortUnit(int[] array, int low, int high)
        {
            int key = array[low];
            while (low < high)
            {
                while (low < high && array[high] > key)
                    high--;
                array[low] = array[high];
                while (low < high && array[low] <= key)
                    low++;
                array[high] = array[low];
            }
            array[low] = key;
            return high;
        }
    }
}
