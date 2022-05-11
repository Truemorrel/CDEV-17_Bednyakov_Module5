using System;

namespace Task_5_3_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var someName = "Сергей";
            Console.WriteLine(someName);
            GetName(someName);
            Console.WriteLine(someName); 
            Console.ReadKey();
        }
        static void GetName(string name)
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
        }
    }
}
