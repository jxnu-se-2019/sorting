using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Xuqiao
{
    class WjmHeapSorter:SorterBase
    {
        public override void Sort(int[] b)
        {
            int maxid = GetMax(b.Length, b);
            HeapSort(maxid, b);
        }
        public static void Swap(int maxIdx, int idx, int[] lst)
        {
            int midx = maxIdx;
            int temp = lst[idx];
            lst[idx] = lst[maxIdx];
            lst[maxIdx] = temp;
        }
        public static int GetMax(int maxLen, int[] lst)
        {
            int maxIdx = 0;
            for (var i = 0; i < maxLen; i++)
            {
                if (lst[i] > lst[maxIdx])
                    maxIdx = i;
            }

            return maxIdx;
        }
        public static IList<int> HeapSort(int maxIdx, int[] lst)
        {
            int i = lst.Length - 1;
            int k = 0;

            while (i > -1)
            {
                Swap(maxIdx, i, lst);
                k++;
                maxIdx = GetMax(lst.Length - k, lst);
                i--;
            }

            return lst;
        }
    }
}
