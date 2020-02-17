using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    static class SortAray
    {
        public static void BubbleSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;
            bool swapDetected = false;
            while (true)
            {
                swapDetected = false;
                for (int index = 0; index < array.Length - 1; index++)
                {
                    if (array[index] < array[index + 1])
                    {
                        int tmp = array[index];
                        array[index] = array[index + 1];
                        array[index + 1] = tmp;
                        swapDetected = true;
                    }
                }

                if (!swapDetected)
                    break;
            }
        }

        public static void SelectionSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;
            for (int index = 0; index < array.Length; index++)
            {
                int maxIndex = index;
                for (int next = index + 1; next < array.Length; next++)
                    if (array[maxIndex] < array[next])
                        maxIndex = next;
                if (maxIndex != index)
                {
                    int tmp = array[index];
                    array[index] = array[maxIndex];
                    array[maxIndex] = tmp;
                }

            }
        }
    }
}
