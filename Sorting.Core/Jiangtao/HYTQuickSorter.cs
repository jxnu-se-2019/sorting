﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Core.Jiangtao
{
    public class HYTQuickSorter : SorterBase
    {
        public override void Sort(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            QuickSort(input, 0, input.Length - 1);
        }
        private static void QuickSort(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                int middle = numbers[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;
                while (true)
                {
                    while (numbers[++i] < middle) ;
                    while (numbers[--j] > middle) ;
                    if (i >= j)
                        break;
                    Swap(numbers, i, j);
                }
                QuickSort(numbers, left, i - 1);
                QuickSort(numbers, j + 1, right);
            }
        }
        private static void Swap(int[] numbers, int i, int j)
        {
            int number = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = number;
        }
    }
}