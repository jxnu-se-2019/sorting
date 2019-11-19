using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Wuqi
{
    class WYCSelectionSort : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            Select(input);
        }
        public void Select(int[] array)
        {
            int temp;
            int number;
            int numindex;
            bool flag;
            for (int i = 0; i < array.Length - 1; i++)
            {
                flag = true;
                number = array[i];
                numindex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (number > array[j])
                    {
                        number = array[j];
                        numindex = j;
                        flag = false;
                    }
                }
                temp = array[i];
                array[i] = array[numindex];
                array[numindex] = temp;
                if (flag == true)
                {
                    break;
                }
            }
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
