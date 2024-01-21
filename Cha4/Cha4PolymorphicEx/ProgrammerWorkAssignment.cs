//ProgrammerWorkAssignment.cs--程序员工作任务分配过程模拟
//多态实现
using System;

namespace Cha4PolymorphicEx
{
    //程序员接口
    interface IProgramerInterface
    {
        void WriteCode();
    }

    //C程序员
    public class CProgramer : IProgramerInterface
    {
        public void WriteCode()
        {
            Console.WriteLine("C");
        }
    }
    //Java程序员
    public class JavaProgramer : IProgramerInterface
    {
        public void WriteCode()
        {
            Console.WriteLine("Java");
        }
    }
    //C#程序员
    public class CSharpProgramer : IProgramerInterface
    {
        public void WriteCode()
        {
            Console.WriteLine("C#");
        }
    }

    //来了一个新项目，指派一个人去工作
    class NewProject
    {
        public void WritePrograme(IProgramerInterface programer)//派一个程序员
        {
            programer.WriteCode();
        }
    }

    //测试类
    public class Test
    { 
    static void Main (string[] args)
        {
            NewProject newP = new NewProject();
            IProgramerInterface programer;
            programer = new CProgramer();//指派C程序员
            newP.WritePrograme(programer);
        }
    }
}
