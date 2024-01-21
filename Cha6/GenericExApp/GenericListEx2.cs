//GenericListEx2.cs-泛型集合示例2
//有一个Person类，它具有Name和Age属性，我们想要创建一个存储Person对象的列表，并对其进行一些操作。
namespace GenericExApp
#nullable disable
{
    //person类
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    //测试类
    public class Test
    {
        public static void Main()
        {
            // 创建一个泛型列表，元素类型为 Person  
            List<Person> people = new List<Person>();

            // 添加人员到列表中  
            people.Add(new Person { Name = "Alice", Age = 45 });
            people.Add(new Person { Name = "Bob", Age = 30 });
            people.Add(new Person { Name = "Charlie", Age = 35 });

            // 遍历列表并输出人员信息  
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            // 按年龄对人员列表进行排序  
            people.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));

            // 输出排序后的人员信息  
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}
