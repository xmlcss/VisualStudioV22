//ComputePlayer.cs--计算机玩家类文件
using System;
#nullable disable
namespace Cha4FingerGuessGame
{
    internal class ComputPlayer
    {
        //保存计算机出拳结果
        public string ComFingerType { get; set; }
        public int ComputerShowFinger()
        {
            Random rd = new Random();
            int r = rd.Next(1, 4);
            //1 石头 ; 2  剪刀 ；  3  布
            switch (r)
            {
                case 1:
                    this.ComFingerType = "石头";
                    break;
                case 2:
                    this.ComFingerType = "剪刀";
                    break;
                case 3:
                    this.ComFingerType = "布";
                    break;
            }
            return r;
        }
    }
}
