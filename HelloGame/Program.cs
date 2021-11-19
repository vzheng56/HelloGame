using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Say("欢迎来到渔夫的比特世界");
            Wait(1);
            Say("........");
            Wait(1);
            Say("怎么称呼你，这位冒险家？");
            var name = GetInput();
            Say(name+" 游戏角色创建中....");
            Wait(1);
            Player player = new Player(name,100,1);
            Say("创建完成");
            Enemy e = new Enemy();
            Say("一个小怪物在你脚下咬你，是否要攻击(1.攻击，2.逃跑)");
            var c = GetInput();
            if (c == "1")
            {
                Say("你用力向怪兽踢过去！");
                Say("........");
                Wait(2);
                player.Attack(e);
                Say("胜利！！");
                Say($"你迎来了第一次胜利！{player.Nickname}");
            }
            else
            {
                Say("有时候逃跑是明智的！");
                var damage = 2;
                player.Damage(damage);
                Say($"玩家损失了{damage}滴血");
                Print("sss");
            }

            while (true)
            {
                Say($"选择操作（1.查看{player.Nickname}的状态, 2.四处游走，3.吃个苹果）");
                var chouse = GetInput();
                switch (chouse)
                {
                    case "1":
                        Say(player.GetInfo());
                        break;
                    case "2":
                        Say("平安无事的一天！");
                        break;
                    case "3":
                        var rand = new Random();
                        var randomBlood = rand.Next(1, 10);
                        Apple apple = new Apple(randomBlood);
                        Say($"一个含有{apple.Blood}滴血的苹果！");
                        player.Eat(apple);
                        break;
                    default:
                        break;
                }
            }
        }

        static void Say(string something)
        {
            Console.WriteLine(something);
        }

        static void Print(string something)
        {
            Console.WriteLine(something);
        }

        static string GetInput()
        {
            var input = Console.ReadLine();
            return input;
        }

        static void Wait(int second)
        {
            System.Threading.Thread.Sleep(second*1000);
        }
    }
}
