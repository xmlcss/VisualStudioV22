//Operation.cs  运算类抽象基类
//定义两个操作数，操作符，GetResult方法

namespace OperationLib
{
    public abstract class Operation
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public Operation(int n1, int n2)
        {
            this.NumberOne = n1;
            this.NumberTwo = n2;
        }
        //记录子类的计算类型
        public abstract string Type { get; }
        //获得结果
        public abstract int GetResult();
    }
}
