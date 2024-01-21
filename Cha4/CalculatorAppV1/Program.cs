#nullable disable
namespace Cha4CalculatorAppV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region:V1
            //Console.Write("请输入数字A：");
            //string A = Console.ReadLine();
            //Console.Write("请选择运算符号(+、-、*、/)：");
            //string B = Console.ReadLine();
            //Console.Write("请输入数字B：");
            //string C = Console.ReadLine();
            //string D = "";
            //if (B == "+")
            //    D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));
            //if (B == "-")
            //    D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));
            //if (B == "*")
            //    D = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(C));
            //if (B == "/")
            //    D = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(C));
            //Console.WriteLine("结果是：" + D);
            #endregion
            #region:V2
            //try
            //{
            //    Console.Write("请输入数字A：");
            //    string strNumberA = Console.ReadLine();
            //    Console.Write("请选择运算符号(+、-、*、/)：");
            //    string strOperate = Console.ReadLine();
            //    Console.Write("请输入数字B：");
            //    string strNumberB = Console.ReadLine();
            //    string strResult = "";
            //    switch (strOperate)
            //    {
            //        case "+":
            //            strResult = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB));
            //            break;
            //        case "-":
            //            strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
            //            break;
            //        case "*":
            //            strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
            //            break;
            //        case "/":
            //            if (strNumberB != "0")
            //                strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
            //            else
            //                strResult = "除数不能为0";
            //            break;
            //    }

            //    Console.WriteLine("结果是：" + strResult);
            //    Console.ReadLine();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("您的输入有错：" + ex.Message);
            //}
            #endregion
            #region:V3
            try
            {
                Console.Write("请输入数字A：");
                string strNumberA = Console.ReadLine();
                Console.Write("请选择运算符号(+、-、*、/)：");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B：");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                strResult = Convert.ToString(Operation.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate));
                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有错：" + ex.Message);
            }
            #endregion
        }
    }

    public class Operation
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

