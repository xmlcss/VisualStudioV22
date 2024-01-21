//骰子游戏
/*
 * Craps掷骰子游戏的规则为：玩家掷两枚骰子。每个骰子有6面，每一面有一个1-6的点数。等两枚骰子停止转动后，计算两个朝上的面中的点数之和。游戏胜负规则为：
如果第一次抛出的点数和为7或11，则玩家获胜。
如果第一次抛出的点数和为2，3或12，则玩家输，庄家赢。
如果第一次掷时点数和为4，5，6，8，9或10，这个和成为玩家所要的“点数”，
    为了获胜，玩家必须继续掷骰子，直到掷出这个相同的点数。
①　如果在掷出相同的点数之前，掷出相同的点数之前掷出来点数7，则玩家输。
依据上述描述，设计并编代码模拟该游戏过程，实现主要游戏功能
 */
using System;


namespace Cha3ProcessControlConApp
{
    internal class CrapsGame
    {
        static void Main(string[] args)
        {
            Craps cr = new Craps();
            cr.playGame();
        }
    }
    /// <summary>
    /// Craps骰子游戏逻辑
    /// </summary>
    class Craps
    {
        private decimal balance;
        private decimal wager;
        private static Random randomNumbers = new Random();
        private enum Status { CONTINUE, WON, LOST }

        private enum DiceNames
        {
            SNAKE_EYES = 2,
            TREY = 3,
            SEVEN = 7,
            YO_LEVEN = 11,
            BOX_CARS = 12
        }

        public void playGame()
        {
            Status gameStatus = Status.CONTINUE;
            int myPoint = 0;
            balance = 1000M;
            this.xiazhu();

            int sumOfDice = this.RollDice();
            switch ((DiceNames)sumOfDice)
            {
                case DiceNames.SEVEN:
                case DiceNames.YO_LEVEN:
                    gameStatus = Status.WON;
                    break;
                case DiceNames.SNAKE_EYES:
                case DiceNames.TREY:
                case DiceNames.BOX_CARS:
                    gameStatus = Status.LOST;
                    break;
                default:
                    gameStatus = Status.CONTINUE;
                    myPoint = sumOfDice;
                    Console.WriteLine("point is {0}", myPoint);
                    break;
            }

            while (gameStatus == Status.CONTINUE)
            {
                sumOfDice = this.RollDice();
                if (sumOfDice == myPoint)
                    gameStatus = Status.WON;
                else
                    if (sumOfDice == (int)DiceNames.SEVEN)
                    gameStatus = Status.LOST;
            }

            if (gameStatus == Status.WON)
            {
                Console.WriteLine("palyers win");
            }
            else
                Console.WriteLine("palyers lose");

        }
        public int RollDice()
        {
            int die1 = randomNumbers.Next(1, 7);
            int die2 = randomNumbers.Next(1, 7);
            int sum = die1 + die2;
            Console.WriteLine("palyer rolled {0}+{1}={2}", die1, die2, sum);
            return sum;
        }
        public void xiazhu()
        {
            Console.WriteLine("下注");
            decimal wage = Convert.ToDecimal(Console.ReadLine());
            while (wage > balance)
            {
                Console.WriteLine("重新下注");
                wage = Convert.ToDecimal(Console.ReadLine());
            }
        }
    }
}
