//DisplayInterfaceMember.cs-显示接口成员示例
//问题：一个类需实现两个接口，两个接口中指定了同名待实现方法
using System;

namespace Cha4PolymorphicEx
{
    interface ICalculate1
    {
        int Add();
    }
    interface ICalculate2
    {
        int Add();
    }

    class Compute : ICalculate1, ICalculate2
    {
        int ICalculate1.Add()//显示接口成员实现
        {
            int x = 10;
            int y = 20;
            return x + y;
        }

        int ICalculate2.Add()//显示接口成员实现
        {
            int x = 10;
            int y = 20;
            int z = 30;
            return x + y + z;
        }
    }
}
