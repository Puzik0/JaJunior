using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamonStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold = 0;
            int diamondsToPay = 0;
            int diamondPrice = 13;
            bool canBuy;
            string greeting = "Вы идёте по базару и вы заметили прилавок с красивыми алмазами. Вы имеете чёткое желание купить себе как можно больше " +
                 "Открыв свой кашель, вы подсчитываете монеты их у вас: ";
            string sellersQuestion = $"Заметив Ваше желание купить Алмазы продавец приятной внешности обращаясь к вас говорит  " +
                $"Добро пожаловать добрый человек, Вы так красивы, что я готов уступить Вам алмазы по самой ниской цене на рынке Крастауна, " +
                $"Всего {diamondPrice} за штуку, сколько Вы бы хотели купить?...";
           
            Console.Write(greeting);
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write(sellersQuestion);
            diamondsToPay = Convert.ToInt32(Console.ReadLine());
            canBuy = (diamondsToPay * diamondPrice) <= gold;
            diamondsToPay = diamondsToPay * Convert.ToInt32(canBuy);
            gold -= (diamondsToPay * diamondPrice);

            Console.WriteLine($" Как только вы назвали число алмазов произошла магическая вспышка, которая ослепила вас на мгновение " +
                $"отшатнувшись назад вы открыли глаза, но лавка исчезла. Всё, что осталось - это кошель с золотом, их там: {gold}. " +
                $"А алмазов у вас в кармане теперь: {diamondsToPay}");
            Console.ReadKey();

        }
    }
}
