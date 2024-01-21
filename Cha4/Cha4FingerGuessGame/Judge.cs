//Judge.cs---石头剪刀布游戏判断逻辑
using System;

namespace Cha4FingerGuessGame
{
    internal class Judge
    {
        public static string JudgeLossWin(int user, int computer)
        {
            //平手
            if (user - computer == 0)
            {
                return "平局";
            }
            else if (user - computer == -1 || user - computer == 2)
            {
                return "恭喜你，你胜了";
            }
            else
            {
                return "额，好遗憾，你输了";
            }
        }
    }
}
