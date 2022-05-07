using System;

namespace Task_5_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sortArr = SortArr(GetArrayFromConsole());
            for(int i = 0; i < sortArr.Length - 1; i++)
            {
                Console.Write(sortArr[i] + " ");
            };
            Console.WriteLine(sortArr[sortArr.Length - 1]);
            Console.ReadKey();
            
        }

        static int[] SortArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int max = arr[i];
                        arr[i] = arr[j];
                        arr[j] = max;
                    }
                }
            }
            return arr;
        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

    }
}
