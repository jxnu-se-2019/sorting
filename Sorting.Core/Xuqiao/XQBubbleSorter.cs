using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Xuqiao
{
    class XQBubbleSorter : SorterBase
    {

        public override void Sort(int[] b)
        {
            if (b == null)
            {
                return;
            }
            int x = b.Length;
            while (x > 0)
            {
                for (int i = 0; i < b.Length - 1; i++)
                {
                    int temp = 0;
                    if (b[i] > b[i + 1])
                    {
                        temp = b[i];
                        b[i] = b[i + 1];
                        b[i + 1] = temp;
                    }
                    else
                        continue;
                }
                x--;
            }
        }
    }
}