using System;
using System.Collections.Generic;

namespace SampleConsoleApp_01
{
    class Program
    {

        static List<int> PositiveList(List<int> list01)
        {
            List<int> resList = new List<int>();
            for (int i = 0; i < list01.Count; i++)
            {
                if (list01[i] > 0)
                {
                    resList.Add(list01[i]);
                }
            }
            return resList;
        }

        static List<int> PositiveListAndAdd(List<int> list01, int number)
        {
            List<int> resList = new List<int>();

            for (int i = 0; i < list01.Count; i++)
            {
                if (list01[i] > 0)
                {
                    resList.Add(list01[i]);
                    resList.Add(number);
                }
                else
                    resList.Add(list01[i]);
            }
            return resList;
        }

        static List<int> RemoveOdd(List<int> list01, int number)
        {
            for (int i = 0; i < list01.Count; i++)
            {
                if (list01[i] % 2 != 0)
                    list01.RemoveAt(i);
            }
            return list01;
        }

        static List<int> ConversionToNumber(List<string> list)
        {
            List<int> listNumb = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                bool sucess = int.TryParse(list[i], out int number);
                if (sucess)
                {
                    listNumb.Add(number);
                }
            }
            return listNumb;
        }

        static void Main(string[] args)
        {
        }
    }
}
