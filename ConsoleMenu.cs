using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fortuneTellingWeather = "Weather";
            const string requestRandom = "Number";
            const string clearWindow = "Clear";
            const string exit = "Exit";
            const string help = "Help";
            const string egg = "Egg";

            Random random = new Random();
            int minValue1 = 20;
            int maxValue1 = 40;
            int weatherDegrees = random.Next(minValue1, maxValue1);

            string userInsert = "";
            string unnownRequest = $"Я тебя не понял... попробуй ввести {help}";
            string greeting = $"Привет! Хочешь понять, что тут да как пиши: {help}, Если я тебе уже надоел пиши: {exit}";

            Console.WriteLine(greeting);

            while (userInsert != "Exit")
            {
                userInsert = Console.ReadLine();

                switch (userInsert)
                {
                    case help:
                        Console.WriteLine($"Тут есть такие команды:" +
                            $"\n{exit} - Выйти из программы" +
                            $"\n{requestRandom} Рандомное число с заданными параметрами" +
                            $"\n{clearWindow} Очистить консоль" +
                            $"\n{fortuneTellingWeather} На сколько будет летом жарко" +
                            $"\n{egg} Пасхалка");
                        break;

                    case exit:
                        Console.WriteLine("Удачи!");
                        Console.ReadKey();
                        break;

                    case requestRandom:
                        Console.WriteLine("Введите максимальное и минимально число для рандома");
                        Console.Write("введите минимальное число: ");
                        int minValue = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("введите максимально число: ");
                        int maxValue = Convert.ToInt32(Console.ReadLine());
                        int requestedRandomNumb = random.Next(minValue, maxValue);
                        Console.WriteLine($"Ваше рандомное число: {requestedRandomNumb}");
                        break;

                    case clearWindow:
                        Console.Clear();
                        Console.WriteLine(greeting);
                        break;

                    default:
                        Console.WriteLine(unnownRequest);
                        break;

                    case fortuneTellingWeather:
                        Console.WriteLine("Хочешь погадать какая будет средняя температура воздуха этим летом?" +
                            "\nДа - если согласен");
                        userInsert = Console.ReadLine();

                        if (userInsert != "Нет")
                        {
                            Console.WriteLine(weatherDegrees);
                        }

                        break;

                    case egg:
                        Console.WriteLine("Какая пасхалка в консоли, ты шо?");
                        break;
                }
            }
        }
    }
}
