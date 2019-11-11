using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Yuyazhi
{
    public class YYZBucketSort:SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            BucketSort(input);
        }
        private static void BucketSort(int[] input)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for(int i=0;i<input.Length;i++)
            {
                max = Math.Max(max, input[i]);
                min = Math.Min(min, input[i]);
            }
            int bucketnum = (max - min) / input.Length + 1;
            List<List<int>> bucketinput = new List<List<int>>(bucketnum);
            for(int i=0;i<bucketnum;i++)
            {
                bucketinput.Add(new List<int>());
            }
            for(int i=0;i<input.Length;i++)
            {
                int num = (input[i] - min) / input.Length;
                bucketinput[num].Add(input[i]);
            }
            for(int i=0;i<bucketnum;i++)
            {
                bucketinput[i].Sort();
            }
            int index = 0;
            for(int i=0;i<bucketinput.Count;i++)
            {
                for(int j=0;j<bucketinput[i].Count;j++)
                {
                    input[index++] = bucketinput[i][j];
                }
            }
        }
    }
}
