//Cha4ClassAndMethodApp项目中的MethodCallEx1.cs文件
//同一个类中方法调用演示
namespace Cha4ClassAndMethodApp
{
    internal class MethodCallEx1
    {       
            public int FindMax(int num1, int num2)
            {
                /* local variable declaration */
                int result;

                if (num1 > num2)
                    result = num1;
                else
                    result = num2;
                return result;
            }
            static void Main(string[] args)
            {
                /* local variable definition */
                int a = 100;
                int b = 200;
                int ret;
               MethodCallEx1 f= new MethodCallEx1();
               //calling the FindMax method
                ret = f.FindMax(a, b);
                Console.WriteLine("Max value is : {0}", ret);
                Console.ReadLine();
            }
        }    
}
