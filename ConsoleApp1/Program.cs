using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int bossHealth = rand.Next(250, 500);
            int bossAttackSword = rand.Next(20, 50);
            int bossAttackAxe = rand.Next(40, 60);
            int playerHealth = rand.Next(70, 100);
            int playerMana = 10;

            bool helpTor = true;
            bool helpOdin = false;

            Console.WriteLine("\n-Ты темный эльф, маг который носит с собой лук");
            Console.ReadKey();
            Console.WriteLine("\n-Путешествуя по мидгарду тебе встречается на пути древний храм богов");
            Console.ReadKey();
            Console.WriteLine("\n-В поиске ценных вещей ты заходишь в нутрь и спускаешься в подземенье");
            Console.ReadKey();
            Console.WriteLine("\n-После нескольких минут блуждания по коридорам ты находишь большую дверь");
            Console.ReadKey();
            Console.WriteLine("\n-Не долго думая ты открываешь дверь и заходишь в большой и теный зал");
            Console.ReadKey();
            Console.WriteLine("\n-Пройдя несколько шагов ты не замечаешь и настумаешь на нажимную плиту на полу");
            Console.ReadKey();
            Console.WriteLine("\n-Внезапно зажигаются факела освещая комнату и железные решотки закрывают все двери");
            Console.ReadKey();
            Console.WriteLine("\n-Осмотревшись ты замечаешь в центре комнаты человека стоящим с топором и мечом в руках");
            Console.ReadKey();
            Console.WriteLine("\n-Осознав что ты в ловушке ты достаешь свой лук и готовишься к бою\n");
            Console.ReadKey();

            while (bossHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine($"\nУ тебя {playerHealth} здоровья и {playerMana} маны. У твоего врага {bossHealth} жизней\n");
                Console.ReadKey();

                Console.Write("Закнинание: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Огненный шар");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Закнинание: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Хамелион");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Обращение к богам: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Сила Тора");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Обращение к богам: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Помощь Одина");
                Console.ForegroundColor = ConsoleColor.White;
                if (helpOdin == true)
                {
                    Console.Write("Сила Одина: ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Гнев падших");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Сила Одина: ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Туман войны");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("Лук: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Выстрел в ноги");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Лук: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Выстрел в голову");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Сдаться");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\nКакие ваши дальнейшие действия: ");
                Console.ForegroundColor = ConsoleColor.White;

                switch (Console.ReadLine())
                {
                    case "Огненный шар":
                        if (playerMana >= 4)
                        {
                            int fireBallAttack = rand.Next(20, 45);
                            Console.WriteLine("\n-Вы запускаете огненный шар во врага и сбиваете его с ног");
                            Console.ReadKey();
                            Console.WriteLine($"\n-Вы нанесли {fireBallAttack} урона");
                            Console.ReadKey();
                            bossHealth -= fireBallAttack;
                            playerMana -= 4;
                        }
                        else
                        {
                            Console.WriteLine("\n-У вас не достаточно маны для этого заклинания");
                            Console.ReadKey();
                            Console.WriteLine("\n-Пытаясь провести заклинание у вас нечего не получается");
                            Console.ReadKey();
                            Console.WriteLine("\n-Противник наносит удар топором");
                            Console.ReadKey();
                            Console.WriteLine($"\n-Вы не успеваете отскочить и получаете {bossAttackAxe - 15} урона");
                            Console.ReadKey();
                            playerHealth -= bossAttackAxe - 15;
                        }
                        break;
                    case "Хамелион":
                        if (playerMana >= 3)
                        {
                            Console.WriteLine("\n-Вспомнив самое полезное заклинание из вашей молодости\nкоторое помогала вам безшумно воровать и подглядывать зааа....\n" +
                                "Не важно. Вернемся к бою");
                            Console.ReadKey();
                            Console.WriteLine("\n-Неожиданно для врага вы растворяетесь");
                            Console.ReadKey();
                            Console.WriteLine("\n-Пока действие заклинания не вышло вы безшумно подбигаете к колонне и прячетесь за ней");
                            Console.ReadKey();
                            Console.WriteLine("\n-Пока враг вас ищет у вас есть время востановить силы и здоровье");
                            Console.ReadKey();
                            playerMana -= 3;
                            playerHealth += 50;
                        }
                        else
                        {
                            Console.WriteLine("\n-У вас не достаточно маны для этого заклинания");
                            Console.ReadKey();
                            Console.WriteLine("\n-Пытаясь провести заклинание у вас нечего не получается");
                            Console.ReadKey();
                            Console.WriteLine("\n-Противник наносит удар топором");
                            Console.ReadKey();
                            Console.WriteLine($"\n-Вы не успеваете отскочить и получаете {bossAttackAxe - 15} урона");
                            Console.ReadKey();
                            playerHealth -= bossAttackAxe - 15;
                        }
                        break;
                    case "Сила Тора":
                        if (helpTor == true)
                        {
                            Console.WriteLine("\n-Вы просите помощи у Тора");
                            Console.ReadKey();
                            Console.WriteLine("\n-Бог грома услышал твой зов");
                            Console.ReadKey();
                            Console.WriteLine("\n-Твой враг побледнел увидев как за твоей спитой стоит сам Тор");
                            Console.ReadKey();
                            Console.WriteLine("\n-Он поднял свой молот Мьёльнер и весь гнев тора обрушился на твоего врага");
                            Console.ReadKey();
                            Console.WriteLine("\n-Вашего противника ударила молния и отняла у него 175 здоровья");
                            Console.ReadKey();
                            bossHealth -= 175;
                            helpTor = false;
                        }
                        else
                        {
                            Console.WriteLine("\n-К сожалению Тор больше не может вам помочь");
                            Console.ReadKey();
                            Console.WriteLine("\n-Вам прийдется справляться в одиночьку");
                            Console.ReadKey();
                            Console.WriteLine($"\n-Пока вы звали Тора, ваш противник нанес вам удар мечем и отнял {bossAttackSword} здоровья");
                            Console.ReadKey();
                            playerHealth -= bossAttackSword;
                        }
                        break;
                    case "Помощь Одина":
                        if (helpOdin == false)
                        {
                            Console.WriteLine("\n-Понимая что противник намного сильнее тебя ты зовешь одина на помощь");
                            Console.ReadKey();
                            Console.WriteLine("\n-Тутже из тени выходит странник в шляпе, плаще и без одного глаза а на плечах у него сидят два черных ворона");
                            Console.ReadKey();
                            Console.WriteLine("\n-Теперь рядом с тобой Один. И ты можешь воспользоваться его силой");
                            Console.ReadKey();
                            Console.WriteLine("\n-Пока вы пытались разгледеть Одина враг нанес удар мечем");
                            Console.ReadKey();
                            Console.WriteLine($"\n-Вы получили {bossAttackSword} урона");
                            Console.ReadKey();
                            playerHealth -= bossAttackSword;
                            helpOdin = true;
                        }
                        else
                        {
                            Console.WriteLine("\n-Один уже с тобой");
                            Console.ReadKey();
                            Console.WriteLine("\n-Ты замешкался и пропустил удар топора");
                            Console.ReadKey();
                            Console.WriteLine($"\n-Противник нанес тебе {bossAttackAxe} урона топором");
                            Console.ReadKey();
                            playerHealth -= bossAttackAxe;
                        }
                        break;
                    case "Гнев падших":
                        if (helpOdin == true)
                        {
                            Console.WriteLine("\n-Падшие войны спустились из Азгарда чтобы помочь вам в битве");
                            Console.ReadKey();
                            Console.WriteLine("\n-Твой противник очень сильный войн");
                            Console.ReadKey();
                            Console.WriteLine("\n-Он долго сражался и почти не пропустил не одного удара");
                            Console.ReadKey();
                            Console.WriteLine("\n-Но некоторые великие войны прошлого всётаки сумели его ранить и отняли ему 175 здоровья");
                            Console.ReadKey();
                            bossHealth -= 175;
                        }
                        else
                        {
                            Console.WriteLine("\n-Одина нет с вами и он не может вам помочь");
                            Console.ReadKey();
                            Console.WriteLine("\n-Ты замешкался и пропустил удар топора");
                            Console.ReadKey();
                            Console.WriteLine($"\n-Противник нанес тебе {bossAttackAxe} урона топором");
                            Console.ReadKey();
                            playerHealth -= bossAttackAxe;
                        }
                        break;
                    case "Туман войны":
                        if (helpOdin == true)
                        {
                            Console.WriteLine("\n-Из под ног поднялся густой туман");
                            Console.ReadKey();
                            Console.WriteLine("\n-Вы на ощуп нашли упавшую колонну и спрятались за ней чтобы востановить здоровье и ману");
                            Console.ReadKey();
                            Console.WriteLine("\n-После того как туман рассеился вы продолжили бой");
                            Console.ReadKey();
                            playerHealth += 30;
                            if (playerMana < 10)
                            {
                                playerMana += 2;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n-Одина нет с вами и он не может вам помочь");
                            Console.ReadKey();
                            Console.WriteLine("\n-Ты замешкался и пропустил удар топора");
                            Console.ReadKey();
                            Console.WriteLine($"\n-Противник нанес тебе {bossAttackAxe} урона топором");
                            Console.ReadKey();
                            playerHealth -= bossAttackAxe;
                        }
                        break;
                    case "Выстрел в ноги":
                    case "Выстрел в голову":
                        Console.WriteLine("\n-Натинув титеву вы пытаетесь прицелица");
                        Console.ReadKey();
                        Console.WriteLine("\n-Вы не попали по противнику");
                        Console.ReadKey();
                        Console.WriteLine("\n-Наверное вам стоит научиться лучше обращаться с луком");
                        Console.ReadKey();
                        Console.WriteLine($"\n-После вашего промаха враг наносит вам удар мечем и отнимает {bossAttackSword} жизней");
                        Console.ReadKey();

                        playerHealth -= bossAttackSword;
                        break;
                    case "Сдаться":
                        Console.WriteLine("\n-Вы не можете сражаться и отбрасываете свое оружие в сторону");
                        Console.ReadKey();
                        playerHealth = 0;
                        break;
                }
                if (playerMana < 10)
                {
                    playerMana++;
                }

                if (bossHealth <= 0)
                {
                    Console.WriteLine("\n-Ваш противник без сил падает на колени");
                    Console.ReadKey();
                    Console.WriteLine("\n-Вы подходите к нему с целью добить его но он изчезает как только вы берете его топор");
                    Console.ReadKey();
                    Console.WriteLine("\n-На месте где он сидел сежит не большой кинжал");
                    Console.ReadKey();
                    Console.WriteLine("\n-Вы берете его чтобы разсмотреть");
                    Console.ReadKey();
                    Console.WriteLine("\n-Это оказался очень дорогой нож сделаный из самой лучшей стали и украшен множеством драгоценных камней");
                    Console.ReadKey();
                    if (helpOdin)
                    {
                        Console.WriteLine("\n-Пока вы разглядывали киндал к вам подошел Один");
                        Console.ReadKey();
                        Console.WriteLine("\nОдин - \"Тот с кем ты дрался это был не простой войн\"");
                        Console.ReadKey();
                        Console.WriteLine("\nОдин - \"Это был Локки\"");
                        Console.ReadKey();
                        Console.WriteLine("\nОдин - \"А этот кинжал твой подарок как благодарность за хороший бой\"");
                        Console.ReadKey();
                        Console.WriteLine("\nОдин - \"Только некому не расказывай что ты победил бога\"");
                        Console.ReadKey();
                        Console.WriteLine("\nОдин - \"Тебе всё-равно не поверят\"");
                        Console.ReadKey();
                        Console.WriteLine("\nОдин - \"И я полностью уверен что Локки тебе поддавался\"");
                        Console.ReadKey();
                        Console.WriteLine("\nОдин - \"Удачи тебе войн\"");
                        Console.ReadKey();
                        Console.WriteLine("\nОдин - \"Увидемся в вальхале\"");
                        Console.ReadKey();
                        Console.WriteLine("\nПосле этих слов раздался крик ворона и Один разтворился в темноте");
                        Console.ReadKey();
                    }
                    Console.WriteLine("\n-Походив еще по руинам вы нечего не нашли и отправились на выход с чуством что вас обманули");
                    Console.ReadKey();
                }
                else if (playerHealth <= 0)
                {
                    Console.WriteLine("\n-Без сил вы падаете на колени перед вашим врагом");
                    Console.ReadKey();
                    Console.WriteLine("\n-Подойдя к вам враг поднял в верх свой тапор и одним ударом отрубил вам голову");
                    Console.ReadKey();
                    Console.WriteLine("\n-В момент удара вы на мнгновение разгледели лицо врага");
                    Console.ReadKey();
                    Console.WriteLine("\n-Это был Локки");
                    Console.ReadKey();
                    Console.WriteLine("\n-Проиграть богу в сражении не стыдно");
                    Console.ReadKey();
                    Console.WriteLine("\n-Может в следующей жизни повезет больше");
                    Console.ReadKey();
                }
            }
        }
    }
}