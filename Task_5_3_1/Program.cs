using System;

namespace Task_5_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var someName = "Сергей";
            var someAge = 51;
            Console.WriteLine(someName);
            Console.WriteLine(someAge);
            GetName( someName);
            ChangeAge(someAge);
            Console.WriteLine(someName);
            Console.WriteLine(someAge);
            Console.ReadKey();
        }
        static void GetName(string name)
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
        }
        static void ChangeAge(int age)
        {
            Console.Write("Введите возраст: ");
            age = int.Parse(Console.ReadLine());
        }
    }
}
