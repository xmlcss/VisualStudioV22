//CustomizeEventsEx.cs--自定义事件示例
//发布者类在构造方法中：定义每隔1s，触发计时器的Elapsed事件一次，在该事件中，调用CheckForMessage处理程序，检查信息
//发布者类中的CheckForMessage处理程序：如果产生的随机数为0而且有订阅者，就触发MessageArrived事件
// 订阅者类中，定义MessageArrived事件发生时的具体处理方法DisplayMessage，该方法需要匹配发布者类中定义的MessageHandler委托类型
//测试类中，订阅者订阅事件，建立关联，并启动定时器开始工作

using System;
using System.Timers;
#nullable disable

namespace Cha7EventConsoleApp
{
    //委托类型指定了事件处理方法必须拥有的返回类型和参数
    //使用string参数可以把Connection对象收到的及时消息发送给Display对象
    public delegate void MessageHandler(string messsageText);

    //发布者类
    class Connection
    {
        //定义该事件是Connection类的一个成员
        //MessageArrived是事件名
        //使用event关键字指定要使用的委托类型
        public event MessageHandler MessageArrived;
        private System.Timers.Timer pollTimer;

        public Connection()
        {
            pollTimer = new System.Timers.Timer(1000);//初始化计时器
            //注册计时器Elapsed事件的CheckForMessage处理程序
            pollTimer.Elapsed += new ElapsedEventHandler(CheckForMessage);
        }

        //可访问计时器
        public void Connect()
        {
            pollTimer.Start();//计时器开始工作，每隔100ms触发一次Elapsed事件
        }

        //禁止访问计时器
        public void Disconnect()
        {
            pollTimer.Stop();
        }

        private static Random random = new Random();
        private void CheckForMessage(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("checking for new messages");
            //如果随机数是0，就引发MessageArrived事件，发生的概率是10%
            //MessageArrived !=null判断事件是否有订阅者
            //类似于轮流检测连接，看是否收到消息，不可能每次检测时候，都没有收到
            if ((random.Next(9) == 0) && (MessageArrived != null))
            {
                MessageArrived("hello");//触发MessageArrived事件
            }
        }
    }

    //订阅者类
    public class Display
    {
        //该方法匹配MessageHandler委托类型
        //它不是生成事件的类，所以事件处理程序必须是公共的
        public void DisplayMessage(string message)
        {
            Console.WriteLine("message arrived:{0}", message);
        }
    }

    //入口测试类
    public class ClientPoint
    {
        public static void Main()
        {
            Connection myCon = new Connection();//发布者类对象
            Display myDIsplay = new Display();//订阅者类对象
            //订阅事件，建立关联
            myCon.MessageArrived += new MessageHandler(myDIsplay.DisplayMessage);
            myCon.Connect();//启动定时器
            Console.Read();
        }
    }

}
