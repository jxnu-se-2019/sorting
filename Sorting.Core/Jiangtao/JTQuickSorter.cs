using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Jiangtao
{
    public class JTQuickSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input is empty");
            }
            Sort(input, 0, input.Length - 1);
        }
        private void Sort(int[] input, int a1, int a2)
        {
            if (a1 >= a2)
            {
                return;
            }
            int j = Partition(input, a1, a2);
            Sort(input, a1, j - 1);
            Sort(input, j + 1, a2);
        }
        private static int Partition(int[] input, int a1, int a2)
        {
            int i = a1;
            int j = a2 + 1;
            int v = input[a1];
            int temp = 0;
            while (true)
            {
                while (v > input[++i])
                {
                    if (i == a2)
                    {
                        break;
                    }
                }
                while (v < input[--j])
                {
                    if (j == a1)
                    {
                        break;
                    }
                }
                if (i >= j)
                {
                    break;
                }
                temp = input[i];
                input[i] = input[j];
                input[j] = temp;
            }
            temp = 0;
            temp = input[a1];
            input[a1] = input[j];
            input[j] = temp;
            return j;
        }
    }
}
