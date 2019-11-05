using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Jiangtao
{
    public class HYTSelectionSorter:SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < input.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] < input[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = input[i];
                    input[i] = input[minIndex];
                    input[minIndex] = temp;
                }
            }
        }
    }
}
