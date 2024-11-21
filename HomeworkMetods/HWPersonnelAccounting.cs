using System;

namespace HWPersonnelAccounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string СommandAddAccount = "1";
            const string СommandShowAll = "2";
            const string СommandRemoveAccount = "3";
            const string СommandFamilySearch = "4";
            const string СommandHelp = "6";
            const string СommandExit = "5";

            bool isOpen = true;

            string[] personnelAccounting = { "Тест Валентин Петрович", "Скучный Никлой Кириллович", "Тыква Елена Павловна", "Тангалы Зураб Агургандбеков",
                "Киркорыч Леонид Баскович", "Ряба Татьяна Еписьфановна", "Смольный Владимир Владимирович","Тест Тамара Тестовна"};

            string[] positionsAccounting = { "Бездельник", "Айтишник", "Повар", "Техник", "Ичар", "Бухгалтер", "Охранник", "Тестер" };

            while (isOpen)
            {
                Console.WriteLine($"\n{СommandHelp} - Помощь");
                WriteText("Введите необходимую команду");

                switch (Console.ReadLine())
                {
                    case СommandAddAccount:
                        AddAccount(personnelAccounting, positionsAccounting, out personnelAccounting, out positionsAccounting);
                        continue;

                    case СommandShowAll:
                        ShowAllAccounts(personnelAccounting, positionsAccounting);
                        continue;

                    case СommandRemoveAccount:
                        RemoveAccount(personnelAccounting, positionsAccounting, out personnelAccounting, out positionsAccounting);
                        continue;

                    case СommandFamilySearch:
                        FindeFamilyname(Console.ReadLine(), personnelAccounting);
                        continue;

                    case СommandExit:
                        isOpen = false;
                        break;

                    case СommandHelp:
                        ShowCommands(СommandAddAccount, СommandShowAll, СommandRemoveAccount, СommandFamilySearch, СommandExit);
                        continue;

                    default:
                        ShowError(СommandHelp);
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
            Console.Clear();

            for (int i = 0; i < accountAddress.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {accountAddress[i]} - {accountPositions[i]}");
            }
        }
        static void AddAccount(string[] accountAddress, string[] accountPosition, out string[] newAccountAddress, out string[] newAccountPosition)
        {
            Console.Clear();
            WriteText("Для добавления досье введите ФИО разделяя пробелом.", ConsoleColor.DarkYellow);
            newAccountPosition = AddObjectInArray(accountPosition, Console.ReadLine());
            WriteText("Укажите должность.", ConsoleColor.DarkYellow);
            newAccountAddress = AddObjectInArray(accountAddress, Console.ReadLine());
            WriteText("Данные успешно внесены", ConsoleColor.Green);
        }
        static void RemoveAccount(string[] accountAddress, string[] accountPosition, out string[] changedAccountAddress, out string[] changedAccountPosition)
        {
            Console.Clear();

            WriteText("Укажите номер досье для удаления", ConsoleColor.DarkYellow);

            if (int.TryParse(Console.ReadLine(), out int indexForDeliting) == false || indexForDeliting == 0 || indexForDeliting > accountAddress.Length)
            {
                WriteText("Ошибка ввода, введено не число, 0 или указаное число превышает кол-во строк", ConsoleColor.Red);
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

            tempStrings[strings.Length] = text;
            strings = tempStrings;
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
            Console.Clear();
            WriteText("Введите фамилию для поиска по базе");

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
        static void ShowCommands(string commandAddAccount, string commandShowAll, string commandRemoveAccount, string commandFamilySearch, string commandExit)
        {
            Console.Clear();
            Console.WriteLine($"для управления программой используйте эти команды:" +
                $"\n{commandAddAccount} - Добавить досье" +
                $"\n{commandShowAll} - Показать все досье" +
                $"\n{commandRemoveAccount} - Удалить досье" +
                $"\n{commandFamilySearch} - Поиск досье по фамилии" +
                $"\n{commandExit} - Выход из программы");
        }
        static void ShowError(string СommandHelp)
        {
            Console.Clear();
            WriteText($"ОШИБКА.... \nТакой Команды нет", ConsoleColor.Red);
            WriteText($"\n Попробуйте еще раз или введите:{СommandHelp} - для вывода доступных команд", ConsoleColor.Green);
        }
    }
}
