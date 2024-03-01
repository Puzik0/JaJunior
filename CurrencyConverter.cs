using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "Exit";
            const string CommandHelp = "Help";
            const string Error = "Недостаточно валюты в кошельке";
            const string CommandWallet = "Кошелёк"; 
            const string CommandRubToUsd = "1";
            const string CommandRubToEur = "2";
            const string CommandUsdToRub = "3";
            const string CommandUsdToEur = "4";
            const string CommandEurToRub = "5";
            const string CommandEurToUsd = "6";

            float rublesInWallet;
            float dollarsInWallet;
            float eurosInWallet;
            float currencyToExchange;
            float rubToUsd = 0.0109f;
            float rubToEur = 0.0101f;
            float usdToRub = 91.33f;
            float usdToEur = 0.9251f;
            float eurToRub = 98.72f;
            float eurToUsd = 1.08f;

            string userInput = "";
            string currencyToExchangeQuestion = "Сколько хотите обменять?: ";
            string greeting = "Для вызова доступных команд введи " + CommandHelp;
            string Success = "Операция произведена";

            Console.WriteLine("Введите кол-во валюты у вас на счету.");
            Console.Write("Кол-во рублей: ");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Кол-во долларов: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Кол-во евро: ");
            eurosInWallet = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(greeting);

            while (userInput != CommandExit)
            {
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandRubToUsd:
                            Console.WriteLine("Рубли в Доллары");
                        Console.WriteLine(currencyToExchangeQuestion);
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());

                        if (currencyToExchange <= rublesInWallet)
                        {
                            rublesInWallet -= currencyToExchange;
                            dollarsInWallet += currencyToExchange * rubToUsd;
                            Console.WriteLine(Success);
                        }
                        else
                        {
                            Console.WriteLine(Error);
                        }
                            break;
                    
                    case CommandRubToEur:
                            Console.WriteLine("Рубли в Евро");
                        Console.WriteLine(currencyToExchangeQuestion);
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());
                        if (currencyToExchange <= rublesInWallet)
                        {
                            rublesInWallet -= currencyToExchange;
                            eurosInWallet += currencyToExchange * rubToEur;
                            Console.WriteLine(Success);
                        }
                        else
                        {
                            Console.WriteLine(Error);
                        }
                        break;
                    
                    case CommandUsdToRub:
                            Console.WriteLine("Доллары в Рубли");
                        Console.WriteLine(currencyToExchangeQuestion);
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());
                        if (currencyToExchange <= dollarsInWallet)
                        {
                            dollarsInWallet -= currencyToExchange;
                            rublesInWallet += currencyToExchange * usdToRub;
                            Console.WriteLine(Success);
                        }
                        else
                        {
                            Console.WriteLine(Error);
                        }
                        break;
                    
                    case CommandUsdToEur:
                            Console.WriteLine("Доллары в Евро");
                        Console.WriteLine(currencyToExchangeQuestion);
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());
                        if (currencyToExchange <= dollarsInWallet)
                        {
                            dollarsInWallet -= currencyToExchange;
                            eurosInWallet += currencyToExchange * usdToEur;
                            Console.WriteLine(Success);
                        }
                        else
                        {
                            Console.WriteLine(Error);
                        }
                        break;
                    
                    case CommandEurToRub:
                            Console.WriteLine("Евро в Рубли");
                        Console.WriteLine(currencyToExchangeQuestion);
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());
                        if (currencyToExchange <= eurosInWallet)
                        {
                            eurosInWallet -= currencyToExchange;
                            rublesInWallet += currencyToExchange * eurToRub;
                            Console.WriteLine(Success);
                        }
                        else
                        {
                            Console.WriteLine(Error);
                        }
                        break;
                    
                    case CommandEurToUsd:
                            Console.WriteLine("Евро в Доллары");
                        Console.WriteLine(currencyToExchangeQuestion);
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());
                        if (currencyToExchange <= eurosInWallet)
                        {
                            eurosInWallet -= currencyToExchange;
                            dollarsInWallet += currencyToExchange * eurToUsd;
                            Console.WriteLine(Success);
                        }
                        else
                        {
                            Console.WriteLine(Error);
                        }
                        break;

                    case CommandHelp:
                        Console.WriteLine($"Доступные конвертации: " +
                             $"\nПиши: {CommandRubToUsd} - рубли в доллары" +
                             $"\nПиши: {CommandRubToEur} - Рубли в евро" +
                             $"\nПиши: {CommandUsdToRub} - Доллары в рубли" +
                             $"\nПиши: {CommandUsdToEur} - Доллары в евро" +
                             $"\nПиши: {CommandEurToRub} - Евро в рубли" +
                             $"\nПиши: {CommandEurToUsd} - Евро в доллары" +
                             $"\nПиши: {CommandHelp} - Если нужна будет помощь" +
                             $"\nПиши: {CommandExit} - Для завершения работы конвертора" +
                             $"\nПиши: {CommandWallet} - Для просмотра доступной валюты в кошельке");
                        break;

                    case CommandWallet:
                        Console.WriteLine($"Доступная валюта: " +
                            $"\nРубли:{rublesInWallet} " +
                            $"\nДоллары:{dollarsInWallet}" +
                            $"\nЕвро:{eurosInWallet}");
                        break;

                    case CommandExit:
                        Console.WriteLine("Спасибо за использования нашего конвертора. Хорошего Вам дня!");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Не корректная команда");
                        break;
                }
            }
        }
    }
}
