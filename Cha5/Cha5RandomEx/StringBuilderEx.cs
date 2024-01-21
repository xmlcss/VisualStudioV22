//stringBuilder.cs
using System;
using System.Text;
namespace Cha5RandomEx
{
    internal class StringBuilderEx
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            // 添加字符串 
            sb.Append("Hello"); sb.Append(" ");
            sb.Append("World!");

            // 插入字符串 
            sb.Insert(6, "beautiful ");
            Console.WriteLine(sb.ToString()); // 输出 "Hello beautiful World!" 

            // 删除字符串 
            sb.Remove(0, 5); // 删除从索引0开始的5个字符 
            Console.WriteLine(sb.ToString()); // 输出 "beautiful World!" 

            // 替换字符串 
            sb.Replace("beautiful", "greeting");
            Console.WriteLine(sb.ToString()); // 输出 "greeting World!"
        }
    }
}
