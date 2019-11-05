using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Jianglinhai
{
    class JLHShellSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                return;
            }
            shell(input);

        }
        public static void shell(int[] a)
        {
            int d = a.Length / 2;
            while (d >= 1)
            {
                for (int i = 0; i < d; i++)
                {
                    for (int j = i + d; j < a.Length; j += d)
                    {
                        int temp = a[j];
                        int loc = j;
                        while (loc - d >= i && temp < a[loc - d])
                        {
                            a[loc] = a[loc - d];
                            loc = loc - d;
                        }
                        a[loc] = temp;
                    }
                }
                d = d / 2;
            }
        }
    }
}
