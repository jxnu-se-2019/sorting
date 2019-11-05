using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Xuqiao
{
    class WjmQuickSorter:SorterBase
    {
        public override void Sort(int[] b)
        {
            Sorting(b, 0, b.Length - 1);
        }
        public static void Sorting(int[] array, int left, int right)
        {
            if (left >= right)
                return;
            int index = SortUnit(array, left , right);
            Sorting(array, left, index - 1);
            Sorting(array, index + 1, right);
        }
        public static int SortUnit(int[] array, int left, int right)
        {
            int key = array[left];
            while (left < right)
            {
                while (left < right && array[right] > key)
                    right--;
                array[left] = array[right];
                while (left < right && array[left] <= key)
                    left++;
                array[right] = array[left];
            }
            array[left] = key;
            return right;
        }
    }
}
