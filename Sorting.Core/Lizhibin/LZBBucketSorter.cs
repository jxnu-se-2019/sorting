using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Lizhibin
{
    public class LZBBucketSortet : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            int i, j;
            int[] count = new int[100];
            for (i = 0; i < 100; i++)
                count[i] = 0;
            for (i = 0; i < input.Length; i++)
                (count[input[i]])++;
            for (i = 0, j = 0; i < 100; i++)
                for (; count[i] > 0; (count[i])--)
                    input[j++] = i;
        }

    }
}
