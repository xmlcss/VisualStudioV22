//数组示例
using System;

namespace Cha3ProcessControlConApp
{
    internal class ArrayExample
    {
        static void Main()
        {
            #region:一维数组
            //Random rd = new Random();
            ////声明数组
            //int[] score;
            ////数组初始化
            //score = new int[10];
            ////数组赋初值
            //for (int i = 0; i < 10; i++)
            //{
            //    score[i] = rd.Next(0, 100);
            //}
            ////输出数组值
            //int j = 0;
            //foreach (int i in score)
            //{
            //    Console.WriteLine("score[{0}]={1}", j, i);
            //    j += 1;
            //}
            #endregion
            #region：二维数组
            int[,] scores;
            //初始化二维数组并赋初值
            scores = new int[2, 3] {
            {68,79,66 } ,//第一个学生成绩
            {99,99,99 }  //第二个学生成绩
            };//两个学生的三门课成绩
            //二维数组元素访问
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine("a[{0},{1}]={2}", i, k, scores[i, k]);
                }
            }
            #endregion
        }
    }
}
