using System;

namespace Task_5_3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenArr = 10;
            var result = GetArrayFromConsole(out lenArr);
            ShowArray(result, true);
            Console.ReadKey();
        }

        private static void ShowArray(int[] arr, bool isToSort = false)
        {
            var result = arr;
            if (isToSort)
            {
                result = SortArray(arr);
            };
            for (int i = 0; i < result.Length - 1; i++)
            {
                Console.Write(result[i] + " ");
            };
            Console.WriteLine(result[result.Length - 1]);
        }

        static int[] SortArray(int[] arr)
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
        static int[] GetArrayFromConsole(out int num)
        {
            num = 6;
            var inputArr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                inputArr[i] = int.Parse(Console.ReadLine());
            }
            return inputArr;
        }
    }
}
