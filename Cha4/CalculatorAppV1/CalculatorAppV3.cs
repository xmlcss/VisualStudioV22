//第三版解决方案：引入面向对象编程之继承特性

namespace Cha4CalculatorApp
{
    /// <summary>
    /// 运算类
    /// </summary>
   public class Operation3
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
    class OperationAdd3 : Operation3
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
    class OperationSub3 : Operation3
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
    class OperationMul3 : Operation3
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
    class OperationDiv3 : Operation3
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
}
