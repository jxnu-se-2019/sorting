using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Lizhibin
{
    public class XXQuickSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            QuickSort(input, 0, input.Length-1);
        }

        public static int Division(int []a, int left, int right)
        {
            while (left < right)
            {
                int num = a[left];
                if (num > a[left + 1])
                {
                    a[left] = a[left + 1];
                    a[left + 1] = num;
                    left++;
                }
                else
                {
                    int temp = a[right];
                   a[right] = a[left + 1];
                    a[left + 1] = temp;
                    right--;
                }
                //Console.WriteLine(string.Join(",", a));
            }
            return left;
        }
        public static void QuickSort(int []a, int left, int right)
        {
            if (left < right)
            {
                int i = Division(a, left, right);
                QuickSort(a, i + 1, right);
                QuickSort(a, left, i - 1);
            }
        }



    }
}
