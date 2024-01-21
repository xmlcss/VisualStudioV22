//机会游戏
using System;

namespace Cha3ProcessControlConApp
{
    internal class ChanceGame
    {
        static void Main(string[] args)
        {
            int RandKey = number();
            bool isExit = true;
            int guessnum = 1;
            while (isExit)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (!guess(RandKey, n))
                {
                    guessnum++;
                    continue;
                }
                if (guessnum < 10)
                {
                    Console.WriteLine("you got lucky!");
                }
                else if (guessnum > 10)
                {
                    Console.WriteLine("you should be able to do better!");
                }
                else
                {
                    Console.WriteLine("aha,you know the secret!");
                }
                Console.WriteLine("是否在玩一次？（Yes 1  No 0）");
                int n1 = Convert.ToInt16(Console.ReadLine());
                if (n1 == 0)
                    isExit = false;
                else
                {
                    Console.Clear();
                    guessnum = 0;
                    RandKey = number();
                }
            }
        }
        private static int number()
        {
            Random ran = new Random();
            int RandKey = ran.Next(1, 1000);
            Console.WriteLine("guess a number between 1 and 1000:");
            return RandKey;
        }
        private static bool guess(int randkey, int n)
        {
            if (n > randkey)
            {
                Console.WriteLine("too  high，try again!");
                return false;
            }
            else if (n < randkey)
            {
                Console.WriteLine("too low，try again!");
                return false;
            }
            else
            {
                Console.WriteLine("congratulations,you guessed the number!");
                return true;
            }
        }
    }
}
