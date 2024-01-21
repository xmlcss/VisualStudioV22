//GenericListEx1.cs--泛型集合基本示例1
using System;
using System.Collections.Generic;

namespace GenericExApp
{
        internal class GenericListEx1
    {
       public static void Main()
        {
            //泛型集合基本使用，整型泛型集合，保存学生成绩
            List<int> stuScoreList = new List<int>();
            stuScoreList.Add(89);//添加成绩
            stuScoreList.Add(59);
            stuScoreList.Add(99);

            //获取元素总数
            Console.WriteLine("集合元素总数" + stuScoreList.Count.ToString());

            //某个位置插入一个元素
            stuScoreList.Insert(2, 70);
    
            for (int i = 0; i < stuScoreList.Count; i++)
            {
                Console.WriteLine(stuScoreList[i]);
            }
            //删除一个元素
            stuScoreList.Remove(70);//删除某值
            stuScoreList.RemoveAt(2);//删除指定索引位置的元素
            //全部删除
            stuScoreList.Clear();

            //集合初始化器，字符串泛型集合，完成学生名称的赋值
            List<string> nameList = new List<string>() { "xiaozhang", "lisi", "wangwu" };
            //遍历的方式输出名字集合中的每一个元素
            foreach (string x in nameList)
            {
                Console.WriteLine(x);
            }
        }
    }
}
