//MethodOverrideEx.cs
//方法重载示例
//要求：创建一个名为SumUtils的类，在类中分别定义计算两个整数、两个小数、两个字符串类型的和，以及从1到给定整数的和
using System;

namespace Cha4ClassAndMethodApp
{
  public class SumUtils
    {
        public int Sum(int a, int b) { return a + b; }
        public double Sum(double a, double b) { return a + b; }
        public string Sum(string a, string b) { return a + b; }
        public int Sum(int a) { int sum = 0; for (int i = 1; i < a; i++) { sum += i; } return sum; }
    }

    class Program
    {
        static void Main(string[] args)
    {
        SumUtils s = new SumUtils();
        //调用两个整数求和的方法
        Console.WriteLine("两个整数的和为：" + s.Sum(3, 5));
        //调用两个小数求和的方法
        Console.WriteLine("两个小数的和为：" + s.Sum(3.2, 5.6));
        //调用两个字符串连接的方法
        Console.WriteLine("连个字符串的连接结果为：" + s.Sum("C#", "方法重载"));
        //输出1到10的和
        Console.WriteLine("1到10的和为："+s.Sum(10));
    }
}
}
