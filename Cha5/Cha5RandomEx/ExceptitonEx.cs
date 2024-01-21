//Exception.cs--异常处理示例
using System;
#nullable disable
namespace Cha5RandomEx
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字:");
            string input1 = Console.ReadLine();
            double number1;
            if (double.TryParse(input1, out number1))
            {
                Console.WriteLine("请输入运算符(+、-、*、/):");
                string operatorInput = Console.ReadLine();
                if (operatorInput == "+" || operatorInput == "-" || operatorInput == "*" || operatorInput == "/")
                {
                    Console.WriteLine("请输入第二个数字:");
                    string input2 = Console.ReadLine();
                    double number2;
                    if (double.TryParse(input2, out number2))
                    {
                        try
                        {
                            double result = CalculateResult(number1, operatorInput, number2);
                            Console.WriteLine($"结果是: {result}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("输入的运算符或数字格式不正确！");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("除数不能为零！");
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入的数字格式不正确！");
                    }
                }
                else
                {
                    Console.WriteLine("输入的运算符不正确！");
                }
            }
            else
            {
                Console.WriteLine("输入的数字格式不正确！");
            }
            Console.ReadKey();
        }

        static double CalculateResult(double number1, string operatorInput, double number2)
        {
            switch (operatorInput)
            {
                case "+": return number1 + number2;
                case "-": return number1 - number2;
                case "*": return number1 * number2;
                case "/": return number1 / number2;
                default: throw new InvalidOperationException("无效的运算符"); // 理论上不应该到达这里，但为了完整性还是加上异常处理。  
            }
        }
    }
}
 
