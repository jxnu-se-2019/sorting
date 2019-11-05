using System;
using System.Collections.Generic;
using System.Text;
namespace Sorting.Core.Wuqi
{
    public class WQMergeSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            MergeSort(input, 0, input.Length - 1);
        }
        private static void Merge(int[] a, int low, int mid, int high)
        {
            int N = high - low + 1;
            int[] b = new int[N];
            int left = low, right = mid + 1, bIdx = 0;
            while (left <= mid && right <= high)
                b[bIdx++] = (a[left] <= a[right]) ? a[left++] : a[right++];
            while (left <= mid)
                b[bIdx++] = a[left++];
            while (right <= high)
                b[bIdx++] = a[right++];
            for (int k = 0; k < N; k++)
                a[low + k] = b[k];
        }
        private static void MergeSort(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSort(a, low, mid);
                MergeSort(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
    }
}
