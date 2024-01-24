//nonymousMethodEx.cs--匿名方法使用示例
using System;

namespace Cha7DelegateExApp
{
    internal class AnonymousMethodEx
    { 
        public  delegate double ProcessDelegate(double n1, double n2);
 
        public static void Main()
        {
            #region:简单的匿名方法示例1
            Action myAction = () => Console.WriteLine("Hello, World!");
            myAction.Invoke(); // 输出 "Hello, World!"
            #endregion

            #region:匿名方法示例2
            //匿名方法创建委托实例,减法
            ProcessDelegate pd = delegate (double param1, double param2)
            {
                //匿名方法的主体
                Console.WriteLine("anonymous method");
                return (param1 - param2);
            };//此处要加分号
            #endregion
            Console.WriteLine(pd(12, 45));//匿名方法调用
        }
    }
}

