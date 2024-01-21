using System;
#nullable disable
namespace Cha3ProcessControlConApp
{
    internal class ForExample
    {
        static void Main( )
        {
            #region:for，求和
            //int sum = 0;
            //for (int i = 2; i <= 20; i = i + 2)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine("{0}", sum);
            #endregion
            #region:while,输出10到20之间的整型数值
            //int a = 10;
            //// while loop execution 
            //while (a < 20)
            //{
            //    Console.WriteLine("value of a: {0}", a);
            //    a++;
            //}
            #endregion
            #region:计算复利
            //decimal amount = 1000m;//初始金额
            //float annualInterestRate = 0.05f;//年利率
            //int i = 1;
            //while (i <= 10)
            //{
            //    amount = Convert.ToDecimal((1000 * Math.Pow((1 + annualInterestRate), i)));
            //    Console.WriteLine("第{0}年的存款余额为:{1:0.00}元", i, amount);
            //    i++;
            //}
            #endregion
            #region：计算若干个学生的平均成绩，标记控制，while循环
            //int total = 0;
            //int gradeCounter = 0;

            //var x = Console.ReadLine();
            //int grade = int.Parse(x);//第一次输入          

            //while (grade != -1)
            //{
            //    total = total + grade;
            //    gradeCounter++;
            //    var y = Console.ReadLine();
            //    grade = int.Parse(y);//接受下一次输入
            //}

            //Console.WriteLine($"average is {total / gradeCounter}");
            #endregion

            #region：【1】局部变量定义和赋初值
            int total = 0;//成绩总和
            int gradeCounter = 0;//输入的成绩个数
            int aCount = 0;//优秀等级的个数
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;
            int eCount = 0;
            #endregion

            #region:【2】提示信息并输入数据
            Console.WriteLine("enter the integer grades in the range 0-100");
            string input = Console.ReadLine();//第一次输入成绩
            #endregion

            #region:【3】判断成绩等级
            while (input != null)
            {
                if (input == "a")
                    break;
                else
                {
                    int grade = int.Parse(input);//把字符串转换成整型
                    total += grade;//把新的成绩加入到总和
                    ++gradeCounter;

                    //判断成绩属于哪个等级
                    switch (grade / 10)
                    {
                        case 9:
                        case 10:
                            ++aCount;
                            break;
                        case 8:
                            ++bCount;
                            break;
                        case 7:
                            ++cCount;
                            break;
                        case 6:
                            ++dCount;
                            break;
                        default:
                            ++eCount;
                            break;
                    }

                    //接受下一次的输入，放入input
                    input = Console.ReadLine();
                }
            }
            #endregion

            #region:【4】输出成绩报表
            Console.WriteLine("\ngrade report");
            if (gradeCounter != 0)
            {
                double average = (double)total / gradeCounter;
                Console.WriteLine($"total of the {gradeCounter} grades entered is {total}");
                Console.WriteLine($"class average is {average}");
            }
            #endregion
        }
    }
}