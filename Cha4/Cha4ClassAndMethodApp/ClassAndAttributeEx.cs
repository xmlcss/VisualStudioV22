//AttributeEx.cs
//Person类：属性、自动属性、可读可写属性、只读属性演示
//Student类：属性初始化器演示
using System;
#nullable disable
namespace Cha4ClassAndMethodApp
{
    /// <summary>
    /// Person类
    /// 字段、属性、方法示例
    /// </summary>
    class Person
    {
        //数据（字段）
        string name; //姓名
        byte age;//年龄
        bool sex;//性别
        float height;//身高（单位：米）
        ushort weight;//体重（单位：斤）
       
        //属性
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public DateTime Birthday { get; set; }
        public byte Age
        {
            get
            {
                int temp= DateTime.Now.Year - Birthday.Year;
                return (byte)temp;
            }
            //set
            //{
            //    if (value >126)
            //    {Console.WriteLine("age is invalid"); }                    
            //    else
            //    {age = value; }                    
            //}
        }


        //行为（方法）
        public void sleep()
        { }
        public void eat()
        { }

    }

    /// <summary>
    /// Student类，演示属性初始化器
    /// </summary>
    class Student
    {
        public string StuName { get; set; }
        public string StuId { get; set; }
        public int StuAge { get; set; }
    }

    /// <summary>
    /// 测试类
    /// </summary>
    class TestClass
    {
        static void Main()
        {
            #region:Person类测试
            Person xiaowang = new Person();
            // xiaowang.Age = 127;
            xiaowang.Birthday = Convert.ToDateTime("1990-5-6");
            Console.WriteLine(xiaowang.Age);
            #endregion

            #region：Student类测试
            Student stu1 = new Student
            {
                StuName = "zhagnsan",
                StuId = "123",
                StuAge = 16
            };
            Console.WriteLine(stu1.StuName + "," + stu1.StuId);
            #endregion
        }
    }
}
