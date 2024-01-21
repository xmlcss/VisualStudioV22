//Player.cs 玩家类
using System;
#nullable disable
namespace Cha4FingerGuessGame
{
    internal class Player
    {
        private string fingerType;//玩家出拳的结果

        public string FingerType
        {
            get
            {
                return fingerType;
            }
            set
            {
                fingerType = value;
            }
        }
        /// <summary>
        /// 玩家出拳
        /// </summary>
        public int PlayerShowFinger(string fistType)
        {
            this.FingerType = fistType;
            int result = -1;
            switch (fistType)
            {
                case "石头":
                    result = 1;
                    break;
                case "剪刀":
                    result = 2;
                    break;
                case "布":
                    result = 3;
                    break;
            }
            return result;
        }
    }
}
