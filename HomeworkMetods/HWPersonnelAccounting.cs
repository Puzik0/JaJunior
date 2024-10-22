using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        WriteText("Для добавления досье введите ФИО разделяя пробелом");
                        personnelAccounting = AddAccount(Console.ReadLine(), personnelAccounting);
                        WriteText("Укажите должность...");
                        positionsAccounting = AddAccount(Console.ReadLine(), positionsAccounting);
                        WriteText("Данные внесены", ConsoleColor.Green);
                        continue;

                    case "2":
                        Console.Clear();
                        ShowAllAccounts(personnelAccounting, positionsAccounting);
                        continue;

                    case "3":
                        Console.Clear();
                        RemoveAccount(personnelAccounting, positionsAccounting, out personnelAccounting, out positionsAccounting);
                        continue;

                    case "4":
                        Console.Clear();
                        WriteText("Введите фамилию для поиска по базе");
                        FindeFamilyname(Console.ReadLine(), personnelAccounting);
                        continue;

                    case "5":
                        isOpen = false;
                        break;

                    case "6":
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
        static void ShowAllAccounts(string[] strings1, string[] strings2)
        {
            for (int i = 0; i < strings1.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {strings1[i]} - {strings2[i]}");
            }
        }
        static string[] AddAccount(string text, string[] strings)
        {
            AddObjectInArray(strings);
            strings[strings.Length - 1] = text;
            WriteText("Данные успешно внесены", ConsoleColor.Green);
            return strings;
        }
        static void RemoveAccount(string[] strings, string[] strings1, out string[] changedString, out string[] changedString1)
        {
            WriteText("Укажите номер досье для удаления", ConsoleColor.DarkYellow);
            int indexForDeliting = Convert.ToInt32(Console.ReadLine());

            if (indexForDeliting == 0 || indexForDeliting > strings.Length)
            {
                WriteText("Введено некорректное значение", ConsoleColor.Red);
                changedString = strings;
                changedString1 = strings1;
            }

            else
            {
                for (int i = indexForDeliting; i < strings.Length; i++)
                {
                    strings[i - 1] = strings[i];
                    strings1[i - 1] = strings1[i];
                }

                changedString = RemoveObjectFromArray(strings, indexForDeliting);
                changedString1 = RemoveObjectFromArray(strings1, indexForDeliting);
                WriteText("Запись успешно удалена", ConsoleColor.Green);
            }
        }
        static string[] AddObjectInArray(string[] strings)
        {
            string[] tempStrings = new string[strings.Length + 1];

            for (int i = 0; i < strings.Length; i++)
            {
                tempStrings[i] = strings[i];
            }

            strings = tempStrings;
            return strings;
        }
        static string[] RemoveObjectFromArray(string[] strings, int value)
        {
            string[] tempStrings = new string[strings.Length - 1];

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
