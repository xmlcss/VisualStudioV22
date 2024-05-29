//CalculatorAppV4.cs
//计算器程序，输入两数以及加减乘除操作符，计算结果并输出
//计算器第四版解决方案：面向对象（封装、继承、多态）+简单工厂模式
using System;
#nullable disable
namespace Cha4CalculatorApp
{
    /// <summary>
    /// 运算类
    /// </summary>
    class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;
        /// <summary>
        /// 数字A
        /// </summary>
        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        /// <summary>
        /// 数字B
        /// </summary>
        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }
        /// <summary>
        /// 得到运算结果
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
    /// <summary>
    /// 加法类
    /// </summary>
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    /// <summary>
    /// 减法类
    /// </summary>
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    /// <summary>
    /// 乘法类
    /// </summary>
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    /// <summary>
    /// 除法类
    /// </summary>
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("除数不能为0。");
            result = NumberA / NumberB;
            return result;
        }
    }

    /// <summary>
    /// 运算类工厂
    /// </summary>
    class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    {
                        oper = new OperationAdd();
                        break;
                    }
                case "-":
                    {
                        oper = new OperationSub();
                        break;
                    }
                case "*":
                    {
                        oper = new OperationMul();
                        break;
                    }
                case "/":
                    {
                        oper = new OperationDiv();
                        break;
                    }
            }
            return oper;
        }
    }
    public class testMain
    {
        public static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.createOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();
            Console.WriteLine(result);
        }
    }
}
