using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Wuqi
{
    public class WQQuickSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            quickSort(0, input.Length, input);
        }
        static void quickSort(int bgn, int end, params int[] arr)
        {
            if (bgn >= end - 1)
                return;
            int lindex = bgn;
            int rindex = end - 1;
            int std = arr[lindex];
            while (lindex < rindex)
            {
                while (lindex < rindex)
                {
                    if (arr[rindex] < std)
                    {
                        arr[lindex++] = arr[rindex];
                        break;
                    }
                    --rindex;
                }
                while (lindex < rindex)
                {
                    if (arr[lindex] >= std)
                    {
                        arr[rindex--] = arr[lindex];
                        break;
                    }
                    ++lindex;
                }
            }
            arr[lindex] = std;
            quickSort(bgn, lindex, arr);
            quickSort(rindex + 1, end, arr);
        }
    }
}
