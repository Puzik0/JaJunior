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
            const string CommandFortuneTellingWeather = "Weather";
            const string CommandRequestRandom = "Number";
            const string CommandClearWindow = "Clear";
            const string CommandExit = "Exit";
            const string CommandHelp = "Help";
            const string CommandEgg = "Egg";

            Random random = new Random();
            int minValue1 = 20;
            int maxValue1 = 40;
            int weatherDegrees = random.Next(minValue1, maxValue1);

            string userInsert = "";
            string agree = "Да";
            string greeting = $"Привет! Хочешь понять, что тут да как пиши: {CommandHelp}, Если я тебе уже надоел пиши: {CommandExit}";
            string unnownRequest = $"Я тебя не понял... попробуй ввести {CommandHelp}";

            Console.WriteLine(greeting);

            while (userInsert != CommandExit)
            {
                userInsert = Console.ReadLine();

                switch (userInsert)
                {
                    case CommandHelp:
                        Console.WriteLine($"Тут есть такие команды:" +
                            $"\n{CommandExit} - Выйти из программы" +
                            $"\n{CommandRequestRandom} Рандомное число с заданными параметрами" +
                            $"\n{CommandClearWindow} Очистить консоль" +
                            $"\n{CommandFortuneTellingWeather} На сколько будет летом жарко" +
                            $"\n{CommandEgg} Пасхалка");
                        break;

                    case CommandExit:
                        Console.WriteLine("Удачи!");
                        Console.ReadKey();
                        break;

                    case CommandRequestRandom:
                        Console.WriteLine("Введите максимальное и минимально число для рандома");
                        Console.Write("введите минимальное число: ");
                        int minValue = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("введите максимально число: ");
                        int maxValue = Convert.ToInt32(Console.ReadLine());
                        int requestedRandomNumb = random.Next(minValue, maxValue);
                        Console.WriteLine($"Ваше рандомное число: {requestedRandomNumb}");
                        break;

                    case CommandClearWindow:
                        Console.Clear();
                        Console.WriteLine(greeting);
                        break;

                    case CommandFortuneTellingWeather:
                        Console.WriteLine("Хочешь погадать какая будет средняя температура воздуха этим летом?" +
                            "\nДа - если согласен");
                        userInsert = Console.ReadLine();

                        if (userInsert != agree)
                        {
                            Console.WriteLine(weatherDegrees);
                        }
                        break;

                    case CommandEgg:
                        Console.WriteLine("Какая пасхалка в консоли, ты шо?");
                        break;

                    default:
                        Console.WriteLine(unnownRequest);
                        break;
                }
            }
        }
    }
}
