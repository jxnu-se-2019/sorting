using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Xuqiao
{
    class WjmBubbleSorter : SorterBase
    {
        public override void Sort(int[] b)
        {
            for (int i = 0; i < b.Length - 1; i++)
            {
                for (int j = 0; j < b.Length - 1 - i; j++)
                {
                    if (b[j] > b[j + 1])
                    {
                        b[j] = b[j] + b[j + 1];
                        b[j + 1] = b[j] - b[j + 1];
                        b[j] = b[j] - b[j + 1];
                    }
                }
            }
        }
    }
}
