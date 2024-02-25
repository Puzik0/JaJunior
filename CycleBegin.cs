using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesBegin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int retryTimes;

            Console.Write("Что ты хочешь сказать? ");
            userInput = Console.ReadLine();
            Console.Write("Сколько раз повторить? ");
            retryTimes = Convert.ToInt32(Console.ReadLine());

            for (int i = retryTimes; i > 0; i--)
            {
                Console.WriteLine(userInput);
            }
        }
    }
}
