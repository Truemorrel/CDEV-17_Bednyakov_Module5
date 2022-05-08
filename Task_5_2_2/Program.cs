using System;

namespace Task_5_2_2
{
    internal class Program
    {
        static void ShowColor(string color)
        {
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        }
        static void ShowColors(string username = "Jane", params string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
        static void Main(string[] args)
        {

            var favColor = new string[3];

            (string name, int age) = ("Сергей", 51);
            Console.WriteLine($"Мое имя: {name}");
            Console.WriteLine($"Мой возраст: {age}");
            //age = checked((byte)int.Parse(Console.ReadLine()));
            //bool isCorrect = int.TryParse(Console.ReadLine(), out age);
            //age = checked((byte)Convert.ToInt32(Console.ReadLine()));
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст c цифрами: ");
            age = int.Parse(Console.ReadLine());



            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{name}, {age} лет{Environment.NewLine}Напишите свой любимый цвет на английском с маленькой буквы");
                favColor[i] = Console.ReadLine();
                ShowColor(favColor[i]);
            }
            ShowColors(name, "red", "cyan");
            Console.ReadKey();
        }
    }
}
