//TimerEvent.cs--事件的含义
//需求：使用一个简单的计时器对象引发周期性事件，输出字符串
using System;
using System.Timers;
#nullable disable
namespace Cha7EventConsoleApp
{
    internal class TimerEvent
    {
        static string displayString = "this string will apear one letter at a time";
        static void Main(string[] args)
        {
            //引发事件的对象myTimer
            System.Timers.Timer myTimer = new System.Timers.Timer(1000);
            //订阅Timer对象的Elapsed事件
            //事件处理方法为WriteChar
            //事件处理方法的返回类型和参数匹配Elapsed事件指定的委托ElapsedEventHandler
            //该委托是.NET Framework中定义的标准委托之一
            myTimer.Elapsed += new ElapsedEventHandler(WriteChar);

            //简化添加事件处理程序的语法
            //myTimer.Elapsed += WriteChar; 

            //启动Timer对象，周期性引发Elapsed事件，该事件调用WriteChar方法输出文字
            myTimer.Start();
            Console.Read();
        }

        static void WriteChar(object source, ElapsedEventArgs e)
        {
            Console.WriteLine(displayString);
        }
    }
}
