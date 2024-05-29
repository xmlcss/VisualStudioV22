//第二版解决方案：引入面向对象编程之封装特性

namespace Cha4CalculatorApp
{
    public class CalculatorAppV2
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入数字A：");
                string strNumberA = Console.ReadLine();
                Console.Write("请选择运算符号(+、-、*、/)：");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B：");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                strResult = Convert.ToString(Operation2.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate));
                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有错：" + ex.Message);
            }
        }
    }
    public class Operation2
    {
        public static double GetResult(double numberA, double numberB, string operate)
        {
            double result = 0d;
            switch (operate)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    result = numberA / numberB;
                    break;
            }
            return result;
        }
    }
}
}
