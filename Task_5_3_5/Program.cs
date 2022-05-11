using System;

namespace Task_5_3_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var arr = new int[] { 1, 2, 3 };
            var data = 5;
            BigDataOperation(arr, ref data);

            Console.WriteLine(arr[0]);
            Console.ReadKey();

        }

        static void BigDataOperation(int[] arr, ref int data)
        {
            data = 4;
            arr[0] = data;
        }

    }
}