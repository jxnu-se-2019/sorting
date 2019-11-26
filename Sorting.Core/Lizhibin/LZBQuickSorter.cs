using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Lizhibin
{
    public class LZBQuickSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if(input == null)
            {
                throw new ArgumentNullException ();
            }
            QuickSort(input, 0, input.Length);
        }

        private static void QuickSort(int[] a, int left, int right)
        {
            int i = left, j = right - 1, key;
            if (i >= j) return;
            for (key = a[i]; i < j;)
            {
                for (; i < j && a[j] >= key; --j) ;
                a[i] = a[j];
                for (; i < j && a[i] <= key; ++i) ;
                a[j] = a[i];
            }
            a[i] = key;
            QuickSort(a, left, i);
            QuickSort(a, i + 1, right);
        }
    }
}
