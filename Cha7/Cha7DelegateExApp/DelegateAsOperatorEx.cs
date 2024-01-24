//DelegateAsOperateorEx.cs--委托作为算符使用的例题
using System;
#nullable disable
namespace Cha7DelegateExApp
{
    #region:委托作为算符使用例题2
    class AddFunc
    {
        //委托方法  
        static public void Add(int first, int second)
        {
            int res = first + second;
            Console.WriteLine("{0} +{1}={2}", first, second, res);
        }
    }
    class SubstractFunc
    {
        static public void Substract(int first, int second)
        {
            int res = first - second;
            Console.WriteLine("{0} -{1}={2}", first, second, res);
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
            //mo.op = new MathOp.OpDelegate(AddFunc.Add);
            mo.op = new MathOp.OpDelegate(SubstractFunc.Substract);
            mo.Invoke();
        }
    }
    #endregion

    #region:委托作为算符使用例题1
    class DelegateAsOpEx2
    {
        //申明一个委托
        public delegate double BinaryOperator(double x, double y);

        //定义一个Add方法，该方法接受一个BinaryOperator委托作为运算符号，并使用该委托执行加法运算    
        public static double Add(double x, double y, BinaryOperator op)
        {
            return op(x, y);
        }

        //public static void Main()
        //{
        //    //创建实现自定义加法逻辑的委托实例。例如，下面的CustomAdd委托实现了对浮点数的平方后再相加的逻辑：
        //    BinaryOperator customAdd = (x, y) => Math.Pow(x, 2) + Math.Pow(y, 2);
        //    //  现在，您可以使用Add方法并传递自定义的customAdd委托来执行加法运算：
        //    double result = Add(3, 4, customAdd); // result will be 25 (9 + 16)
        //    Console.WriteLine(result.ToString());
        //}
    }
    #endregion
}

