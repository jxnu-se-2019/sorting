using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Xuqiao
{
    class XQQuickSorter : SorterBase
    {
        public override void Sort(int[] b)
        {
            if (b == null)
            {
                return;
            }
            Quick_Sort(b, 0, b.Length - 1);
        }
        static void Quick_Sort(int[] b, int left, int right)
        {
            if (left < right)
            {
                int l = left, r = right, key = b[l];
                while (key <= b[r] && l < r)
                    r--;
                if (b[r] < key)
                {
                    b[l] = b[r];
                    l++;
                }
                while (key >= b[l] && l < r)
                    l++;
                if (key < b[l])
                {
                    b[r] = b[l];
                    r--;
                }
                b[l] = key;
                Quick_Sort(b, left, l - 1);
                Quick_Sort(b, l + 1, right);
            }
        }

    }
}