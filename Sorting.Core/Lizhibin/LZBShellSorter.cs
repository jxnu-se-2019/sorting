using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Lizhibin
{
    class LZBShellSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                return;
            }
            int number = input.Length / 2;
            int i;
            int j;
            int temp;
            while (number >= 1)
            {
                for (i = number; i < input.Length; i++)
                {
                    temp = input[i];
                    j = i - number;
                    while (j >= 0 && input[j] > temp)
                    {
                        input[j + number] = input[j];
                        j = j - number;
                    }
                    input[j + number] = temp;
                }
                number = number / 2;
            }
        }
    }
}
