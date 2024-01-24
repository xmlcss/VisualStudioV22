//DelegateSimpleEx.cs--委托的简单应用示例
using System;
#nullable disable
namespace Cha7DelegateExApp
{
    #region：委托的简单示例
    //internal class DelegateSimpleEx
    //{
    //    delegate double ProcessDelegate(double param1, double param2);//定义/申明委托
    //    static double Multiply(double param1, double param2)//乘法
    //    {
    //        return param1 * param2;
    //    }
    //    static double Add(double param1, double param2)//加法
    //    {
    //        return param1 + param2;
    //    }
    //    static void Main(string[] args)
    //    {
    //        double num1 = 12.3;
    //        double num2 = 45.6;
    //        Console.WriteLine("enter M to multiplay or A to add:");
    //        string input = Console.ReadLine();
    //        ProcessDelegate process;//创建委托类型的变量     
    //        if (input == "M")
    //            process = new ProcessDelegate(Multiply);//初始化委托变量，函数引用
    //        else
    //            process = new ProcessDelegate(Add);

    //        Console.WriteLine("result is {0}", process(num1, num2));//使用委托调用所选函数
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region：回调方法改写上面的简单示例
    class DelegateEx
    {
        //声明或定义委托
        public delegate double ProcessDelegate(double param1, double param2);

        //委托方法1
        public static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }

        //委托方法2
        public static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }

        //其它函数进行方法回调，该方法参数为委托类型的变量
        public static void ExecuteFunction(ProcessDelegate process)
        {
            Console.WriteLine(process(2, 3));
        }
    }
    class entryPoint
    {
        static void Main()
        {
            //实例委托变量
            DelegateEx.ProcessDelegate process = new DelegateEx.ProcessDelegate(DelegateEx.Multiply);
            //委托变量做为参数传递
            DelegateEx.ExecuteFunction(process);
            Console.Read();
        }
    }
    #endregion

}
