//GenericMethodEx.cs--泛型方法演示
using System;
using System.Collections.Generic;


namespace GenericExApp
{
    internal class GenericMethodEx
    {
        //交换值-泛型方法定义
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //打印数组元素-泛型方法定义
        static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            #region：交换值泛型方法调用
            int x = 5;
            int y = 10;
            Swap<int>(ref x, ref y);
            Console.WriteLine(x); // 输出 10  
            Console.WriteLine(y); // 输出 5

            string str1 = "C #";
            string str2 = "NET";
            Swap<string>(ref str1, ref str2);
            Console.WriteLine(str1);
            #endregion

            #region：输出数组元素值泛型方法调用
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            PrintArray(numbers); // 输出: [1, 2, 3, 4, 5]  

            string[] words = new string[] { "apple", "banana", "cherry" };
            PrintArray(words); // 输出: [apple, banana, cherry]  
            #endregion
        }
    }
}
