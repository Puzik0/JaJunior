using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JaJunior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeating = "Вас приветсвует Система, для загрузки Вашего разума на наши сервера, пожалуйста, ответьте на следующие вопросы:";
            string firstQuestion = "Напишете, пожалуйста, Ваше имя: ";
            string secondQuestion = "Сколько Вам лет: ";
            string firdQuestion = "Какой Ваш знак зодиака: ";
            string fourthQuestion = "Где Вы работали до того как приняли решение стать чатью VR вселенной: ";
            string fifthQuestion = "Если вы согласны стать частью системы напишите: ДА ";
            string name;
            int age;
            string zodiac;
            string workPlace;
            Console.WriteLine(greeating);
            Console.Write(firstQuestion);
            name = Console.ReadLine();
            Console.Write(secondQuestion);
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write(firdQuestion);
            zodiac = Console.ReadLine();
            Console.Write(fourthQuestion);
            workPlace = Console.ReadLine();
            Console.WriteLine(fifthQuestion);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Поздравляю Вас, {name}, Вы прожили такую долгую жизнь {age}г. Вас всегда вела звезда {zodiac}. " +
                $"Возможно Вас сильно ценили пока вы работали в {workPlace}. Но теперь вы собственность системы...");

        }

    }
}
