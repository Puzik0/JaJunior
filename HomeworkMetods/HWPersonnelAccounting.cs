using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HWPersonnelAccounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string commandAddAccount = "1";
            const string commandShowAll = "2";
            const string commandRemoveAccount = "3";
            const string commandFamilySearch = "4";
            const string commandExit = "5";
            const string commandHelp = "6";

            bool isOpen = true;

            string[] personnelAccounting = { "Тест Валентин Петрович", "Скучный Никлой Кириллович", "Тыква Елена Павловна", "Тангалы Зураб Агургандбеков",
                "Киркорыч Леонид Баскович", "Ряба Татьяна Епифановна", "Смольный Владимир Владимирович","Тест Тамара Тестовна"};

            string[] positionsAccounting = { "Бездельник", "Айтишник", "Повар", "Техник", "Ичар", "Бухгалтер", "Охранник", "Тестер" };

            while (isOpen)
            {
                Console.WriteLine($"\n{commandHelp} - Помощь");
                WriteText("Введите необходимую команду");

                switch (Console.ReadLine())
                {
                    case commandAddAccount:
                        Console.Clear();
                        WriteText("Для добавления досье введите ФИО разделяя пробелом");
                        personnelAccounting = AddAccount(Console.ReadLine(), personnelAccounting);
                        WriteText("Укажите должность...");
                        positionsAccounting = AddAccount(Console.ReadLine(), positionsAccounting);
                        WriteText("Данные внесены", ConsoleColor.Green);
                        continue;

                    case commandShowAll:
                        Console.Clear();
                        ShowAllAccounts(personnelAccounting, positionsAccounting);
                        continue;

                    case commandRemoveAccount:
                        Console.Clear();
                        RemoveAccount(personnelAccounting, positionsAccounting, out personnelAccounting, out positionsAccounting);
                        continue;

                    case commandFamilySearch:
                        Console.Clear();
                        WriteText("Введите фамилию для поиска по базе");
                        FindeFamilyname(Console.ReadLine(), personnelAccounting);
                        continue;

                    case commandExit:
                        isOpen = false;
                        break;

                    case commandHelp:
                        Console.Clear();
                        Console.WriteLine($"для управления программой используйте эти команды:" +
                            $"\n{commandAddAccount} - Добавить досье" +
                            $"\n{commandShowAll} - Показать все досье" +
                            $"\n{commandRemoveAccount} - Удалить досье" +
                            $"\n{commandFamilySearch} - Поиск досье по фамилии" +
                            $"\n{commandExit} - Выход из программы");
                        continue;

                    default:
                        Console.Clear();
                        WriteText($"ОШИБКА.... \nТакой Команды нет", ConsoleColor.Red);
                        WriteText($"\n Попробуйте еще раз или введите:{commandHelp} - для вывода доступных команд", ConsoleColor.Green);
                        break;
                }
            }
        }
        static void WriteText(string text, ConsoleColor color = ConsoleColor.White)
        {
            ConsoleColor defoult = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = defoult;
        }
        static void ShowAllAccounts(string[] accountAddress, string[] accountPositions)
        {
            for (int i = 0; i < accountAddress.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {accountAddress[i]} - {accountPositions[i]}");
            }
        }
        static string[] AddAccount(string text, string[] strings)
        {
            AddObjectInArray(strings, text);
            WriteText("Данные успешно внесены", ConsoleColor.Green);
            return strings;
        }
        static void RemoveAccount(string[] accountAddress, string[] accountPosition, out string[] changedAccountAddress, out string[] changedAccountPosition)
        {
            WriteText("Укажите номер досье для удаления", ConsoleColor.DarkYellow);
            int indexForDeliting = Convert.ToInt32(Console.ReadLine());

            if (indexForDeliting == 0 || indexForDeliting > accountAddress.Length)
            {
                WriteText("Введено некорректное значение", ConsoleColor.Red);
                changedAccountAddress = accountAddress;
                changedAccountPosition = accountPosition;
            }

            else
            {
                changedAccountAddress = RemoveObjectFromArray(accountAddress, indexForDeliting);
                changedAccountPosition = RemoveObjectFromArray(accountPosition, indexForDeliting);
                WriteText("Запись успешно удалена", ConsoleColor.Green);
            }
        }
        static string[] AddObjectInArray(string[] strings, string text)
        {
            string[] tempStrings = new string[strings.Length + 1];

            for (int i = 0; i < strings.Length; i++)
            {
                tempStrings[i] = strings[i];
            }

            strings = tempStrings;
            strings[strings.Length - 1] = text;
            return strings;
        }
        static string[] RemoveObjectFromArray(string[] strings, int value)
        {
            string[] tempStrings = new string[strings.Length - 1];

            for (int i = value; i < strings.Length; i++)
            {
                strings[i - 1] = strings[i];
            }

            for (int i = 0; i < tempStrings.Length; i++)
            {
                tempStrings[i] = strings[i];
            }

            strings = tempStrings;

            return strings;
        }
        static void FindeFamilyname(string text, string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                string[] substring = strings[i].Split(' ');
                for (int j = 0; j < substring.Length; j++)
                {
                    if (substring[j].ToLower() == text.ToLower())
                    {
                        Console.WriteLine($"{i + 1} - {strings[i]}");
                    }
                }
            }
        }
    }
}
