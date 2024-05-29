using System;
using System.Reflection;
using System.IO;
#nullable disable

namespace ReflectionExConsoleApp
{
    internal class ReflectionEx2
    {
        class Program
        {
            static void Main(string[] args)
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LhlClassLibrary.dll");
                Assembly ass = Assembly.LoadFile(path);
                Console.WriteLine("程序集加载成功");

                //获取程序集中所有公开的数据
                Type[] tps = ass.GetExportedTypes();
                foreach (Type item in tps)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.FullName);
                    Console.WriteLine(item.Namespace);
                }

                //调用Animal中的默认无参构造函数创建实例
               // object o = ass.CreateInstance("LhlClassLibrary.Animal");
                //Console.WriteLine(o.GetType());

                //获取要创建的数据的类型，此处获取程序集中的animal类
                Type t = ass.GetType("LhlClassLibrary.Animal");
                object o = Activator.CreateInstance(t, "wangcai", 3);

                //获得数据源中的属性组
                PropertyInfo[] pros = o.GetType().GetProperties();
                foreach (PropertyInfo item in pros)
                {
                    Console.WriteLine(item.Name);
                }

                //获取数据源中的方法组
                MethodInfo[] mets = o.GetType().GetMethods();
                foreach (MethodInfo item in mets)
                {
                    Console.WriteLine(item.Name);
                }
             }
        }
    }
}
