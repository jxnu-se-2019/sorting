using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Wuqi
{
    public class WQSelectionSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            int temp;
            for (int i = 0; i < input.Length; i++)
            {
                int minindex = i;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[minindex] > input[j])
                        minindex = j;
                }
                if (minindex != i)
                {
                    temp = input[minindex];
                    input[minindex] = input[i];
                    input[i] = temp;
                }
            }
        }
    }
}
