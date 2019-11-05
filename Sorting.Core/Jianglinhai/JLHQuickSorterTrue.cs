using System;
namespace Sorting.Core.Jianglinhai
{
    public class JLHQuickSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                return;
            }
            kuaisu(input, 0, input.Length - 1);
        }
        public static void kuaisu(int[] a, int left, int right)
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
                kuaisu(a, 0, left - 1);
                kuaisu(a, left + 1, right);
            }
            Console.WriteLine("快速排序：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("\t" + a[i]);
            }
            Console.WriteLine();
        }
    }

}
