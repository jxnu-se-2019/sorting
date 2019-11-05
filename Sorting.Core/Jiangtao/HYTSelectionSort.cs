using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Jiangtao
{
    public class HYTSelectionSort:SorterBase
    {
        public override void Sort(int[] dataArray)
        {
            if (dataArray == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < dataArray.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < dataArray.Length; j++)
                {
                    if (dataArray[j] < dataArray[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = dataArray[i];
                    dataArray[i] = dataArray[minIndex];
                    dataArray[minIndex] = temp;
                }
            }
        }
    }
}
