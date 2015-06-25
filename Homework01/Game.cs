using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    public class Game
    {
        private Player player1 = new Player();
        private Player player2 = new Player();

        public void Start()
        {
            Random random = new Random();

            player1.name = "你";
            player2.name = "電腦";

            Console.Write("請輸入你要出的拳, 0: 剪刀, 1: 石頭, 2: 布");
            player1.mora.WhichOne = SelectPunch();
            Console.WriteLine("{0}出的是{1}", player1.name, player1.mora.TypeOfMora);

            player2.mora.WhichOne = random.Next(0, 3);
            Console.WriteLine("{0}出的是{1}", player2.name, player2.mora.TypeOfMora);

            Judge(player1.mora.WhichOne, player2.mora.WhichOne);
        }

        private int SelectPunch()
        {
            return int.Parse(Console.ReadLine());
        }

        private void Judge(int punch1, int punch2)
        {
            if ((punch1 == 0 && punch2 == 1) || (punch1 == 1 && punch2 == 2) || (punch1 == 2 && punch2 == 0))
            {
                Console.WriteLine("{0}贏了{1}", player2.name, player1.name);
            }
            else if ((punch1 == 0 && punch2 == 2) || (punch1 == 1 && punch2 == 0) || (punch1 == 2 && punch2 == 1))
            {
                Console.WriteLine("{0}贏了{1}", player1.name, player2.name);
            }
            else if (punch1 >= 3)
            {
                Console.WriteLine("不符合規定, 不列入評定");
            }
            else
            {
                Console.WriteLine("平手");
            }
        }
    }
}