//DelegateAndNonStaticMethod.cs-委托与非静态方法
using System;
#nullable disable
namespace Cha7DelegateExApp
{
    //程序员类
    public class ProgrammerNew
    {
        public string Name { get; set; }

        public void WriteCode()//写代码
        {
            Console.WriteLine(Name + "程序员开始写代码");
        }
    }
    //销售员类
    public class SellerNew
    {
        public string Name { get; set; }

        public void TakeBusiness()//跑业务
        {
            Console.WriteLine(Name + "销售员开始去出跑业务");
        }
    }
    //客服类
    public class SrvNew
    {
        public string Name { get; set; }

        public void CallPhone()//打电话
        {
            Console.WriteLine(Name + "客服开始打电话回访");
        }
    }
    public class BossNew
    {
        //老板说开始工作
        public void SendCommand(List<Action> actionList)
        {
            //foreach循环，用于遍历actionList列表中的每一个元素
            //actionList是一个包含Action委托的列表，Action委托通常用于表示没有返回值的方法。
            foreach (Action action in actionList)
                //  ?.    :是null条件运算符,如果action不为null，则调用其Invoke方法；如果action为null，则不执行任何操作。
                action?.Invoke();          //Invoke(): 是委托的调用方法。当委托不为null时，这个方法会被调用。
        }
    }

    //测试入口类
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            ProgrammerNew employee1 = new ProgrammerNew() { Name = "程大大" };
            SellerNew employee2 = new SellerNew() { Name = "销美美" };
            SrvNew employee3 = new SrvNew() { Name = "客小服" };

            //Action为system中定义的委托
            Action action1 = employee1.WriteCode;
            Action action2 = employee2.TakeBusiness;
            Action action3 = employee3.CallPhone;

            //List<Action> actionList = new List<Action>();
            //actionList.Add(action1);
            //actionList.Add(action2);
            //actionList.Add(action3);
            List<Action> actionList = [action1, action2, action3];

            BossNew boss = new BossNew();
            boss.SendCommand(actionList);

            Console.Read();
        }
    }
}
