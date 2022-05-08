﻿using System;

namespace Task_5_2_2
{
    internal class Program
    {
        static void ShowColor(string username, int userage, params string[] favColor)
        {
            foreach(var color in favColor)
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
        }
        static void Main(string[] args)
        {

            var favColor = new string[3];
                
            (string name, int age) person;
            Console.Write("Как вас зовут? ");
            person.name = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            //person.age = checked((byte)int.Parse(Console.ReadLine()));
            bool isCorrect = int.TryParse(Console.ReadLine(), out person.age);
            //person.age = checked((byte)Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Ваше имя: {0}", person.name);
            Console.WriteLine("Ваш возраст: {0}", person.age);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{person.name}, {person.age} лет\nНапишите свой любимый цвет на английском с маленькой буквы\n");
                favColor[i] = Console.ReadLine();
            }
            ShowColor(person.name, person.age, favColor);

            foreach (var fav in favColor)
            {
                Console.WriteLine(fav);
            }
            Console.ReadKey();
        }
    }
}
