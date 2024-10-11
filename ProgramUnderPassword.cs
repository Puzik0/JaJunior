using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUnderPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Password = "HARDpassword";

            int attemptsPasswordInput = 3;

            string userInput;

            for (int i = 0; i < attemptsPasswordInput; i++)
            {
                Console.WriteLine("Введите пароль");
                userInput = Console.ReadLine();

                if (userInput == Password)
                {
                    Console.WriteLine("Вы успешно вошли в программу");
                    break;
                }
            }
        }
    }
}
