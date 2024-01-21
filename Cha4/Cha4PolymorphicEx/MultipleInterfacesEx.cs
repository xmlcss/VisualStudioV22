//MultipleInterfaces.cs--模拟动物的继承关系
//知识点：多重接口实现
using System;
#nullable disable
namespace Cha4PolymorphicEx
{
    /// <summary>
    /// animal接口
    /// </summary>
    interface IAnimalInterface//接口名称需始终冠以大写字母I
    {
        //string nickName;//错误，接口声明中不包括数据成员
        string NickName { get; set; }//属性
        void Bark();//在指定方法时，只需给出返回类型、名称和参数列表，然后以分号结束
    }

    interface IRun
    {
        void Run();
    }

    /// <summary>
    /// dog类
    /// </summary>
    public class Dog : IAnimalInterface//实现接口用冒号
    {
        public string NickName { get; set; }//接口的每种方法都必须在派生类中实现
        public void Bark()//接口中的方法实现，方法不能重写
        {
            Console.WriteLine("wang wang");
        }
    }

    /// <summary>
    /// cat类
    /// </summary>
    public class Cat : IAnimalInterface, IRun
    {
        public string NickName { get; set; }
        public void Bark()
        {
            Console.WriteLine("miao miao");
        }
        public void Run()
        {
            Console.WriteLine("the cat is running");
        }
    }

    /// <summary>
    /// 测试类
    /// </summary>
    public class Test
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.NickName = "wangcai";
            dog1.Bark();

            Cat garfield = new Cat();
            garfield.Bark();
            Console.ReadKey();
        }
    }
}
