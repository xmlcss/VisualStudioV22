namespace Cha3ProcessControlConApp
{
    internal class GradeBook
    {
        //保存学生成绩的数组
        int[] grades;

        //第一步：和属性相关的私有实例变量，私有实例变量命名时，第一个词语的字母小写
        private string courseName;

        //第二步：定义针对私有实例变量的读取和设置值的属性方法
        public string CourseName
        {
            //通过get方法获取私有变量courseName的值
            get
            {
                return courseName;
            }
            //set方法设置私有变量courseName的值
            set
            {
                courseName = value;
            }
        }

        #region:GradeBook类的构造方法，通过这个构造方法初始化值

        public GradeBook(string tempCourseName, int[] gradesArr)
        {
            courseName = tempCourseName;
            grades = gradesArr;//成绩数组赋初值
        }


        #endregion

        #region:方法的定义，功能：显示欢迎信息，不带参数
        public void ShowMessage()
        {

            Console.WriteLine("welcome to the grade book for {0}!", CourseName);
        }
        #endregion

        #region:方法的定义，功能：显示欢迎信息，带课程名称参数
        public void ShowMessage(string CourseName)
        {
            Console.WriteLine("welcome to the grade book for {0}!", CourseName);
        }
        #endregion

        #region:计数器循环计算平均成绩
        //方法的定义
        public void DeterminClassAverage()
        {
            //方法体
            //第一步：定义一些局部变量
            int total;
            int counter;
            int grade;
            int average;

            //第二步：给部分需要的局部变量赋初值
            total = 0;
            counter = 1;

            //第三步，因为循环次数确定，选择计数器循环来输入成绩，计算总和
            while (counter <= 5)
            {
                Console.Write("enter grade:");
                grade = Convert.ToInt16(Console.ReadLine());
                total = total + grade;
                counter = counter + 1;
            }

            //第四步，计算平均值，输出结果
            average = total / 5;
            Console.WriteLine("\n Total of all 5 grades is {0}", total);
            Console.WriteLine("class average is {0}", average);
        }

        #endregion

        #region:标记控制循环，成绩个数不确定
        public void ComputeClassAverage()
        {
            //第一步，定义局部变量
            int total;//总成绩
            int counter;//计数器
            int grade;//单个成绩
            int average;//平均值

            //第二步：赋初值
            total = 0;
            counter = 0;

            //第三步，因为循环次数不确定，所以选择标记控制循环语句
            Console.Write("enter grade or -1 to quit: ");//-1就是哑元值，来控制循环是继续还是停止
            grade = Convert.ToInt16(Console.ReadLine());

            while (grade != -1)
            {
                total = total + grade;
                counter = counter + 1;
                Console.Write("enter grade or -1 to quit:  ");
                grade = Convert.ToInt16(Console.ReadLine());
            }

            if (counter > 0)
            {
                average = total / counter;
                Console.WriteLine("\n total of {0} grades entered is {1}", counter, total);
                Console.WriteLine("class average is {0}", average);
            }
            else
                Console.WriteLine("no grades were entered");
        }
        #endregion

        #region:显示学生的成绩
        public void OutPutGrades()
        {
            Console.WriteLine("the grades are:\n");
            //循环语句输出成绩
            for (int student = 0; student < grades.Length; student++)
            {
                Console.WriteLine("student{0,2}:{1,3}", student + 1, grades[student]);
            }
        }
        #endregion

        #region：求学生成绩中的最高分
        #endregion

        #region：统计不及格人数
        #endregion
    }
}
