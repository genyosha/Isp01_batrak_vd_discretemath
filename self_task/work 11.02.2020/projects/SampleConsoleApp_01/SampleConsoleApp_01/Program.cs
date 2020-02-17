using System;

namespace ConsoleApp5
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 2, 5, 9, 333 };
            //проверка метода Bubble
            SortAray.BubbleSort(array);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            //проверка метода Selection
            SortAray.SelectionSort(array);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            Console.ReadKey();
        }
    }
}