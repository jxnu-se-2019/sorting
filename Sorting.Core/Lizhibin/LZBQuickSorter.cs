using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Lizhibin
{
    class LZBQuickSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if(input == null)
            {
                return;
            }
            void quick_sort(int[] a, int left, int right)
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
                quick_sort(a, left, i);
                quick_sort(a, i + 1, right);
            }
            quick_sort(input, 0, input.Length);
        }
    }
}
