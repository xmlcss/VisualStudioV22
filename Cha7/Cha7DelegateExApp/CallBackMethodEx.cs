//CallBackMethodEx.cs--委托用作回调方法
//需求：模拟前台服务员的工作过程
//说明：前台服务员可以执行很多工作，其中一项就是对文件的打印或者发送，经理给前台服务员指派本次工作任务，前台完成
using System;


namespace Cha7DelegateExApp
{
 
    internal class CallBackMethodEx
    {
        // 定义一个委托类型，说明前台服务员的服务接口，可以接受文件，对文件执行后续操作
        delegate void MyDelegate(string message);
        public static void Main()
        {
            // 创建一个回调函数对象，经理说明本次任务
            MyDelegate callback = SendMessage;

            // 调用Work Process，接受本次任务，开始工作
            WorkProcess(callback);
        }

        // 回调函数，定义前台服务员打印文件的工作
        static void PrintMessage(string message)
        {
            Console.WriteLine("执行打印工作"+message);
        }

        //回调函数，定义前台服务员发送文件的工作
        static void SendMessage(string message)
        {
            Console.WriteLine("执行发送工作" + message);
        }

        // 其他函数，接受回调函数作为参数，指定前台服务员本次需要执行的具体任务
        static void WorkProcess(MyDelegate callback)
        {
            // 在这里调用回调函数
            callback("Hello, Callback!");
        }

    }





}
