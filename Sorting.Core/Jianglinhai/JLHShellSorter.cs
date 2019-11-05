using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Jianglinhai
{
    public class JLHShellSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            shell(input);
        }
        public static void shell(int[] a)
        {
            int flag = a.Length / 2;
            while (flag >= 1)
            {
                for (int i = 0; i < flag; i++)
                {
                    for (int j = i + flag; j < a.Length; j += flag)
                    {
                        int temp = a[j];
                        int loc = j;
                        while (loc - flag >= i && temp < a[loc - flag])
                        {
                            a[loc] = a[loc - flag];
                            loc = loc - flag;
                        }
                        a[loc] = temp;
                    }
                }
                flag = flag / 2;
            }
        }
    }
}
