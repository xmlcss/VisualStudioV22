//ReflectionSimpleDemo.cs--反射简单示例
using System;
using System.Reflection;
#nullable disable
namespace ReflectionExConsoleApp
{

    public class Calculator
    {
        public int Result { get; set; }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            //【1】显示Calculator类中所有属性
            Type type = typeof(Calculator);

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties )
            {
                Console.WriteLine($"Property Name: {property.Name}, Property Type: {property.PropertyType}");
            }

            //【2】创建对象实例并调用类中方法
            object obj = Activator.CreateInstance(type);//创建对象实例（方法不是静态的）
            MethodInfo mInfo = type.GetMethod("Add");//获取方法信息（需指定方法名）
            // 创建参数数组（因为Add方法接受两个int参数）  
            object[] arguments = { 5, 3 };
            // 使用InvokeMember方法调用Add方法，并将结果存储在result变量中
            object result =mInfo.Invoke(obj, arguments);//如果方法是静态，省略第一个参数； 

            // 输出结果  
            Console.WriteLine(result); // 输出: 8  
        }
    }
}
