using System;

namespace NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int symbolsForBoard = 2; 
            int lengthUserName;

            string outputSymbolString ="";
            string userName;
            string specialSymbol;

            Console.WriteLine("Введите Ваше имя");

            userName = (Console.ReadLine());

            Console.WriteLine("Введите специальный символ");

            specialSymbol = (Console.ReadLine());

            lengthUserName = userName.Length + symbolsForBoard;

            for (int i = 0; i < lengthUserName; i++)
            {
                outputSymbolString += specialSymbol;
            }

            Console.WriteLine($"{outputSymbolString} \n{specialSymbol + userName + specialSymbol} \n{outputSymbolString}");
        }
    }
}
