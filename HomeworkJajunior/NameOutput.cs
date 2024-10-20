using System;

namespace NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfStrings;
            string outputSymbolString ="";
            string userName;
            string specialSymbol;
            string middleString; 

            Console.WriteLine("Введите Ваше имя");

            userName = (Console.ReadLine());

            Console.WriteLine("Введите специальный символ");

            specialSymbol = (Console.ReadLine());

            middleString = specialSymbol + userName + specialSymbol;

            lengthOfStrings = middleString.Length;

            for (int i = 0; i < lengthOfStrings; i++)
            {
                outputSymbolString += specialSymbol;
            }

            Console.WriteLine($"{outputSymbolString} \n{middleString} \n{outputSymbolString}");
        }
    }
}
