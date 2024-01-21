//InheritApp.cs 继承演示
using System;
#nullable disable
namespace InheritExApp
{
    /// <summary>
    /// Person基类
    /// </summary>
    public class Person
    {
        //数据（字段）
        string name; //姓名
        byte age;//年龄
        bool sex;//性别
        public float height;//身高（单位：米）
        public ushort weight;//体重（单位：斤）   

        //属性
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public byte Age
        {
            get { return age; }
            set { age = value; }
        }

        //构造方法
        public Person(float height, ushort weight)
        {
            this.height = height;
            this.weight = weight;
        }
        //行为（方法）
        public void sleep()
        { }
        public void eat()
        { }
    }

    /// <summary>
    /// Student派生类
    /// </summary>
    public class Student : Person
    {
        private string stuId;
        public string StuId//自实现属性，键入propfull，连按两次tab
        {
            get { return stuId; }
            set { stuId = value; }
        }
        public Student(string stuId, float height, ushort weight) : base(height, weight)
        {
            this.StuId = stuId;
        }
        public void study()
        { }
    }

    public class Test
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("123", 165, 120);
            Console.WriteLine("student id is {0}, weight is {1}", stu1.StuId, stu1.weight);
            Console.ReadKey();
         }
    }
}
