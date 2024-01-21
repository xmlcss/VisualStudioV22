//GradeBook.cs
//GradeBook类，成绩册类逻辑--------------------------------------------------------------------------------------------------------------
/*设计一个成绩簿程序，即学生课程成绩管理应用程序，主要为教师提供服务。该系统可以实现的主要功能包括：
(1)目标1：教师使用该系统时，首先显示“welcome to the grade book!”欢迎消息；
(2)目标2：教师通过该系统，可以完成课程信息、教师信息的设置；
(3)目标3：教师通过该系统，可以录入课程成绩，并显示成绩
(4)目标4：教师通过该系统，可以获取课程成绩的最低分、最高分、统计课程的不及格人数等功能；
(5)目标5：对A，B，C, D和F成绩等级进行计数。要求：判断每个成绩是否等价于A，B，C, D或F成绩等级，并使相应的成绩等级技术器加1。并给出每个成绩等级的学生数的汇总。
--------------------------------------------------------------------------------------------------------------------------------------------------*/
//Test类，测试类
using System;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using Cha4EncapsulationExApp;
using System.Security.Cryptography;
#nullable disable
namespace Cha4EncapsulationExApp
{
    /// <summary>
    /// 成绩册类
    /// </summary>
    internal class GradeBook
    {        
        int[] grades;//保存学生成绩的数组

        #region：目标1：教师使用该系统时，首先显示“welcome to the grade book!”欢迎消息
        //public void ShowMessage()
        //{
        //    Console.WriteLine("welcome to the grade book!");
        //}
        #endregion

        #region：目标2，课程以及教师信息设置
        //目标2：通过方法，完成课程信息设置
        public void ShowMessage(string courseName)//带参方法
        {
            Console.WriteLine("welcome to the grade book for {0}", courseName);
        }
        //目标2：通过属性，设置课程信息
        private string courseName;
        public string CourseName//属性
        {
            get//获取私有字段courseName的值
            {
                return courseName;
            }
            set//设置私有字段courseName的值
            {
                courseName = value;
            }
        }
        //目标2：通过带参构造函数，设置教师名称
        private string teacherName;//教师名称
        public GradeBook(string teaName)//带参构造方法，初始化变量
        {
            this.teacherName = teaName;
        }
        public void ShowMessage()//不带参方法
        {
            Console.WriteLine("{0}! welcome to the grade book for {1}!", teacherName, CourseName);
        }
        #endregion

        #region：目标3：教师通过该系统，录入课程成绩，显示成绩
        //录入成绩
        public void InputScore()
        {
            int counter = 0;
            Console.WriteLine("input student number:");
            int stuNum = Convert.ToInt16(Console.ReadLine());//学生人数
            grades = new int[stuNum];

            while (counter < stuNum)
            {
                Console.Write("enter grade:");
                grades[counter] = Convert.ToInt16(Console.ReadLine());          
                counter = counter + 1;
            }
            Console.WriteLine();
        }

        //显示成绩
        public void OutPutGrades()
        {
            Console.WriteLine("the grades are:");
            //循环语句输出成绩
            for (int student = 0; student < grades.Length; student++)
            {
                Console.WriteLine("student{0,2}:{1,3}", student + 1, grades[student]);
            }
        }
        #endregion

        #region：目标4，求最高分、最低分、均值、统计不及格人数等
        //求均值
        public void ComputeSocre()
        {
            float sum = 0;
           float minScore = grades[0];
            float maxScore = grades[0];
            int fallNum = 0;

            //循环语句统计分数
            for (int student = 0; student < grades.Length; student++)
            {
                sum = sum + grades[student];
                if (grades[student] < minScore)
                    minScore = grades[student];
                if (grades[student] > maxScore)
                    maxScore = grades[student];
                if (grades[student] < 60)
                    fallNum++;
            }

            Console.WriteLine("min Score is " + minScore.ToString() + "\n" + "fall number is " + fallNum.ToString());
            Console.WriteLine();
        }
        #endregion

        #region:目标5，分段统计人数
        public void JudgeScore()
        {
            int[] levelCount = new int[5];
            for (int student = 0; student < grades.Length; student++)
            {
                switch (grades[student] / 10)
                {
                    case 9:
                    case 10:
                        levelCount[0]++;
                        break;
                    case 8:
                        levelCount[1]++;
                        break;
                    case 7:
                        levelCount[2]++;
                        break;
                    case 6:
                        levelCount[3]++;
                        break;
                    default:
                        levelCount[4]++;
                        break;
                }
            }
            Console.WriteLine("number of level A: " + levelCount[0].ToString());
            Console.WriteLine("number of level F:" + levelCount[4].ToString());
        }
         #endregion

    }


    /// <summary>
    /// 测试类
    /// </summary>
    public class Test
    {
        public static void Main()
        {
        GradeBook gb = new GradeBook("Li");
            
            #region：目标1调用
            //gb.ShowMessage();
            #endregion

            #region：目标2调用方法--设置课程名称
            Console.WriteLine("input the course name:");
            string courseName = Console.ReadLine();
            gb.ShowMessage(courseName);
            #endregion

            #region：目标2调用属性--设置课程名称
            gb.CourseName = "NET";
            gb.ShowMessage();
            #endregion

            #region：目标3显示-录入并显示成绩
            gb.InputScore();
            gb.OutPutGrades();
            #endregion

            #region:目标4，输出统计成绩
            gb.ComputeSocre();
            #endregion
        }
    }
}
