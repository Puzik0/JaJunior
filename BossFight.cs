using System;

namespace BossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandForAttack = "1";
            const string CommandForUseFireBall = "2";
            const string CommandForUsePotions = "3";
            const string CommandForGuard = "4";
            const string CommandForCheaters = "10";
            const string CommandForHelp = "Help";
            const string heroFall = "Замешкался";

            string heroName = "Безымянный охотник";
            int hpHero = 100;
            int mpHero = 100;
            int attackHero = 5;
            int magicAttack = 10;
            int magicPrice = 20; 
            int holyPotions = 3;
            bool nuckFireBallSwitcher = false;
            string heroTurn = $"{heroName} может атаковать...";
            string heroTakeDamage = $"{heroName} получает урон в размере: ";

            string bossName = "Вялая слизь";
            int hpBoss = 300;
            int attackBoss = 10;
            string bossTurn = $"{bossName} атакует ";
            string bossTakeDamage = $"{bossName} получает урон равный: ";

            string trainingHero = $"*Художественный текст описывающий зависимости атаки от удачи героя и как сила боса увеличивает урон босса* \n" +
                $"И что нужно прописать {CommandForHelp} чтобы увидеть доступные команды";

            Console.WriteLine($"*Художественный текс описывающий Ваше: {heroName} вхождение в подземелье \n" +
                $"и встречу с противником по имени: {bossName}*");
            Console.WriteLine(trainingHero);

            string userCommand = "";

            while (hpHero > 0 && hpBoss > 0)
            {
                Random randomLuck = new Random();
                int minHeroLuck = 0;
                int maxHeroLuck = 3;
                int luckHero = randomLuck.Next(minHeroLuck, maxHeroLuck);

                Random randomBossPower = new Random();
                int minBossPower = 1;
                int maxBossPower = 3;
                int bossPower = randomBossPower.Next(minBossPower, maxBossPower);

                int regularBossattack = attackBoss * bossPower;
                int regularHeroAttack = attackHero * luckHero;

                Console.WriteLine(heroTurn + " Удача: " + luckHero + " Сила босса: " + bossPower);
                Console.WriteLine($"Ваше здоровье:{hpHero}, Запас маны: {mpHero}, Святых склянок: {holyPotions}\n" +
                    $"Здоровье монстра:{hpBoss}");
                userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case CommandForAttack:
                        Console.WriteLine(bossTakeDamage + regularHeroAttack);
                        hpBoss -= regularHeroAttack;

                        Console.WriteLine(bossTurn);
                        Console.WriteLine(heroTakeDamage + regularBossattack);
                        hpHero -= regularBossattack;
                        return;

                    case CommandForUseFireBall:

                        if (nuckFireBallSwitcher == true)
                        {
                            Console.WriteLine("*Художественный текс описывающий взрыв огненного шара* который нанёс урона монстру: " + magicAttack);
                            hpBoss -= magicAttack * (luckHero + 1);
                            Console.WriteLine(bossTurn);
                            Console.WriteLine(heroTakeDamage + regularBossattack);
                            hpHero -= regularBossattack;
                            nuckFireBallSwitcher = false;
                        }
                        else if (nuckFireBallSwitcher == false && mpHero >= magicPrice)
                        {
                            Console.WriteLine("* Художественный текс о запуске огненного шара и о том, что противник засмотрелся на огонёк *");
                            nuckFireBallSwitcher = true;
                            mpHero -= magicPrice;
                        }
                        else
                        {
                            Console.WriteLine("*художественный текст о неудаче при создании заклинания* Недостаточно маны");
                            Console.WriteLine(bossTurn);
                            Console.WriteLine(heroTakeDamage + regularBossattack);
                            hpHero -= regularBossattack;
                        }
                        continue;

                    case CommandForUsePotions:
                        Console.WriteLine("Бутылёк с ярким содержимым был быстро выпит вами");

                        if (holyPotions != 0)
                        {
                            holyPotions--;
                            hpHero = 100;
                            mpHero = 100;
                        }
                        else
                        {
                            Console.WriteLine("Зелья кончились!");
                        }

                        Console.WriteLine(bossTurn);
                        Console.WriteLine(heroTakeDamage + regularBossattack);
                        hpHero -= regularBossattack;
                        continue;

                    case CommandForHelp:
                        Console.WriteLine("Это всё, чему тебя учили" +
                            $"{CommandForAttack} - Атака мечём с помощью силы и удачи\n" +
                            $"{CommandForUseFireBall} - Атака магией, наносит большой урон. После броска необходимо повторно активировать для взрыва.\n" +
                            $"{CommandForUsePotions} - Выпить элексир. Восстанавливает максимальное кол-во здоровья и маны.\n" +
                            $"{CommandForGuard}\n - Поднять щит. Позволяет защититься от сильной атаки монстра");
                        continue;

                    case CommandForGuard:
                        Console.WriteLine("Кусок железа это то, что отделяет вас от атаки монстра");

                        if (bossPower == 2)
                        {
                            Console.WriteLine("Атака монстра оставила внушительную царапину на щите. Натиск был очень сильный вы чувствуете боль в руке.");
                            hpHero -= bossPower;
                        }

                        else
                        {
                            Console.WriteLine("Атака монстра была успешно отбита без урона");
                        }
                        continue;

                    case CommandForCheaters:
                        Console.WriteLine("Пх’нглуи мглв’нафх Ктулху Р’льех вгах’нагл фхтагн");
                        hpHero = 0;
                        continue;

                    default:
                        Console.WriteLine(heroFall);
                        Console.WriteLine(bossTurn);
                        Console.WriteLine(heroTakeDamage + regularBossattack);
                        hpHero -= regularBossattack;
                        continue;
                }
            }

            if (hpBoss <= 0 || hpHero <= 0)
            {
                if (hpBoss <= 0)
                {
                    Console.WriteLine($"*Художественный текст о победе {heroName} над противником {bossName}*");
                    
                }
                else if (hpHero <= 0)
                {
                    Console.WriteLine($"*Художественный текст о том на сколько неудачник: {heroName} был вкусный для страшного монстра: {bossName}*");
                }
                else
                {
                    Console.WriteLine("Сегодня смерть не стала выбирать и забрала две души");
                }

            }
        }
    }
}
