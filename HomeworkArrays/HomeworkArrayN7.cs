using System;

namespace HomeworkArrayN7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForSplit = "Тут должны быть какие-то слова, дабы программа их разделила?";
            string[] someStrings = stringForSplit.Split(' ');

            foreach (string str in someStrings) { Console.WriteLine(str); }

        }
    }
}
