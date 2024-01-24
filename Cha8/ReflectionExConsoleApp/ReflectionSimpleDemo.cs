//ReflectionSimpleDemo.cs--反射简单示例
using System;
using System.Reflection;
#nullable disable
namespace ReflectionExConsoleApp
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            // 创建Calculator类的实例  
            object calculatorInstance = new Calculator();

            // 获取Add方法的MethodInfo对象  
            MethodInfo addMethodInfo = typeof(Calculator).GetMethod("Add");

            // 创建参数数组（因为Add方法接受两个int参数）  
            object[] arguments = { 5, 3 };

            // 使用InvokeMember方法调用Add方法，并将结果存储在result变量中  
            object result = addMethodInfo.Invoke(calculatorInstance, arguments);

            // 输出结果  
            Console.WriteLine(result); // 输出: 8  
        }
    }
}
