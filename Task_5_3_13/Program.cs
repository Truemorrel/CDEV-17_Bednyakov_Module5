using System;

namespace Task_5_3_13
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
            int[] arrasc;
            int[] arrdesc;
            if (isToSort)
            {
                SortArray(arr, out arrasc,out arrdesc);
                Console.WriteLine("по возрастанию:");
                for (int i = 0; i < arrasc.Length - 1; i++)
                {
                    Console.Write(arrasc[i] + " ");
                };
                Console.WriteLine(arrasc[arrasc.Length - 1]);

                Console.WriteLine("по убыванию:");
                for (int i = 0; i < arrdesc.Length - 1; i++)
                {
                    Console.Write(arrdesc[i] + " ");
                };
                Console.WriteLine(arrdesc[arrdesc.Length - 1]);

                return;
            };
            for (int i = 0; i < result.Length - 1; i++)
            {
                Console.Write(result[i] + " ");
            };
            Console.WriteLine(result[result.Length - 1]);
            return;
        }

        static void SortArray(int[] arr, out int[] sortedasc, out int[] sorteddesc)
        {
            sorteddesc = SortArrayDesc(arr);
            sortedasc = SortArrayAsc(arr);
        }

        static int[] SortArrayAsc(int[] arr)
        {
            var result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    result[j] = arr[j];
                    if (arr[i] > arr[j])
                    {
                        int max = arr[i];
                        result[i] = arr[j];
                        arr[i] = arr[j];
                        result[j] = max;
                        arr[j] = max;
                    }
                }
            }
            return result;
        }
        static int[] SortArrayDesc(int[] arr)
        {
            var result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    result[j] = arr[j];
                    if (arr[i] < arr[j])
                    {
                        int min = arr[i];
                        result[i] = arr[j];
                        arr[i] = arr[j];
                        result[j] = min;
                        arr[j] = min;
                    }
                }
            }
            return result;
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
