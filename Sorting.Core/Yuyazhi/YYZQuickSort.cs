using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Yuyazhi
{
    public class YYZQuickSort:SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            Sort(input, 0, input.Length - 1);
        }
        private static void Sort(int[] input,int leftindex,int rightindex)
        {
            int left = leftindex;
            int right = rightindex;
            if(left>=right)
            {
                return;
            }
            int basenum = input[left];
            while(left!=right)
            {
                for(;left<right;right--)
                {
                    if (input[right] < basenum)
                    {
                        input[left] = input[right];
                        break;
                    }        
                }
                for(;left<right;left++)
                {
                    if(input[left]>basenum)
                    {
                        input[right] = input[left];
                        break;
                    }
                }
            }
            input[left] = basenum;
            Sort(input, leftindex, left - 1);
            Sort(input, left + 1, rightindex);
        }
    }
}
