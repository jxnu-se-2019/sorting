using System;
using System.Collections.Generic;
using System.Text;
namespace Sorting.Core.Jianglinhai
{
    public class LTInsertSort : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            insert(input);
        }
        public static void insert(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (a[j] > a[j - 1]) break;
                    else
                    {
                        int sap = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = sap;
                    }
                }
            }
        }
    }
}
