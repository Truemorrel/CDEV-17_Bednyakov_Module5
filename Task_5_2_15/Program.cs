﻿using System;

namespace Task_5_2_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = SortArr(GetArrayFromConsole());

            for (int i = 0; i < result.Length - 1; i++)
            {
                Console.Write(result[i] + " ");
            };
            Console.WriteLine(result[result.Length - 1]);
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

        static int[] GetArrayFromConsole(int num = 5)
        {
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
