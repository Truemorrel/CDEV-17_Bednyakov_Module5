using System;

namespace Task_5_0_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] favDishes) User;
            User.favDishes = new string[3];
            Console.Write("Введите ваше имя ");
            User.Name = Console.ReadLine();
            Console.WriteLine("\nВведите 3 любимых блюда");
            for(int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1} ");
                User.favDishes[i] = Console.ReadLine();
            }
        }
    }
}
 