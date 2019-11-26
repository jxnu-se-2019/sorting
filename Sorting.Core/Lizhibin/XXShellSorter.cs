using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Lizhibin
{
    public class XXShellSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            int length = input.Length;

            for (int h = length / 2; h > 0; h = h / 2)
            {
                for (int i = h; i < length; i++)
                {
                    int temp = input[i];
                    if (temp.CompareTo(input[i - h]) < 0)
                    {
                        for (int j = 0; j < i; j += h)
                        {
                            if (temp.CompareTo(input[j]) < 0)
                            {
                                temp = input[j];
                                input[j] = input[i];
                                input[i] = temp;
                            }
                        }
                    }
                }

            }
            Console.WriteLine(input);

        }
    }
}
