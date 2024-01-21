//AssignWork.cs --指派工作流程模拟
//知识点：抽象类和抽象方法实现多态
using System;
#nullable disable

namespace Cha4PolymorphicEx
{
    /// <summary>
    /// 员工类--抽象基类
    /// </summary>
    public abstract class Employee
    {
        //姓名
        public string Name { get; set; }

        //工作
        public abstract void Work();
    }
  
    /// <summary>
    /// 程序员类-派生类
    /// </summary>
    public class Programmer : Employee
    {
        public override void Work()
        {
            Console.WriteLine(Name + "程序员开始写代码");
        }
    }

    /// <summary>
    /// 销售员类-派生类
    /// </summary>
    public class Seller : Employee
    {
        public override void Work()
        {
            Console.WriteLine(Name + "销售员开始出去跑业务");
        }
    }

    /// <summary>
    /// 客服类-派生类
    /// </summary>
    public class Srv : Employee
    {
        public override void Work()
        {
            Console.WriteLine(Name + "客服开始打电话回访");
        }
    }

/// <summary>
/// 老板类--单独的类
/// </summary>
    public class Boss
    {
        //老板向员工们发话
        public void SendCommand(Employee[] employeeList)
        {
            foreach (Employee emp in employeeList)//员工们开始工作吧
                emp.Work();
        }
    }

    /// <summary>
    /// 测试类
    /// </summary>
    public class Test
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Programmer() {Name="cheng"} ,
                new Seller() {Name="xiao" },
                new Srv () {Name="ke" }
            };

            Boss b1 = new Boss();
            b1.SendCommand(employees);
            Console.Read();
        }
    }
}
