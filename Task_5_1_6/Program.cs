using System;

namespace Task_5_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetArrayFromConsole();
            Console.ReadKey();
            
        }

        static void GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        int max = result[i];
                        result[i] = result[j];
                        result[j] = max;
                    }
                }
            }

            for (int i = 0; i < result.Length - 1; i++)
            {
                Console.Write(result[i] + " ");
            };
            Console.WriteLine(result[result.Length - 1]); ;
        }

    }
}
