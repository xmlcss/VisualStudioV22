//MultiBrodcastDelegate.cs--多播委托示例
using System;
#nullable disable
namespace Cha7DelegateExApp
{
    //加法类
    class AddFunc
    {
        //委托方法  
        static public void Add(int first, int second)
        {
            int res = first + second;
            Console.WriteLine("{0} +{1}={2}", first, second, res);
        }
    }

    //乘法类
    class MultFunc
    {
        //委托方法
        static public void Multiply(int first, int second)
        {
            int res = first * second;
            Console.WriteLine("{0} * {1}={2}", first, second, res);
        }
    }

    //减法类
    class SubtractFunc
    {
        //委托方法
        static public void Subtract(int first, int second)
        {
            int res = first - second;
            Console.WriteLine("{0} - {1}={2}", first, second, res);
        }
    }


    class MathOp
    {
        protected int _first;
        protected int _second;

        public delegate void OpDelegate(int First, int Second);
        public OpDelegate op;//公共字段op，类型为OpDelegete委托

        public MathOp(int first, int second)
        {
            _first = first;
            _second = second;
        }
        //调用op委托，对存储在对象中的操作数进行数学运算
        public void Invoke()
        {
            if (op != null)
                op(_first, _second);
        }
    }

    public class EntryPoint
    {
        public static void Main()
        {
            MathOp mo = new MathOp(12, 2);
            //创建委托实例对象
            mo.op = new MathOp.OpDelegate(AddFunc.Add);
            mo.op += new MathOp.OpDelegate(MultFunc.Multiply);
            mo.op += new MathOp.OpDelegate(SubtractFunc.Subtract);
            mo.Invoke();

            Console.WriteLine("jianshao");
            mo.op -= SubtractFunc.Subtract;
            mo.Invoke();
        }
    }
}
