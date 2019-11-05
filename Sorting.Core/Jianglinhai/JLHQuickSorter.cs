using System;
namespace Sorting.Core.Jianglinhai
{
    public class JLHQuickSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            QuickSort(input, 0, input.Length - 1);
        }
        public static void QuickSort(int[] a, int left, int right)
        {
            int tmp = a[left];
            while (left < right)
            {
                while (a[right] > tmp && left < right)
                {
                    right--;
                }
                a[left] = a[right];
                while (a[left] <= tmp && left < right)
                {
                    left++;
                }
                a[right] = a[left];
                a[left] = tmp;
                QuickSort(a, 0, left);
                QuickSort(a, left, right);
            }
        }
    }
}
