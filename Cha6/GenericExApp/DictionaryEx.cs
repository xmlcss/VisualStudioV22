//Dictionary.cs--字典示例
//有一个应用程序，其中需要存储用户的信息，每个用户有一个唯一的标识符（ID）和一个名字。
namespace GenericExApp
#nullable disable
{
    //用户类
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Test
    {
        public static void Main()
        {
            // 创建一个 Dictionary 来存储 User 对象  
            Dictionary<int, User> users = new Dictionary<int, User>();

            // 添加用户到 Dictionary 中  
            users.Add(1, new User { Id = 1, Name = "Alice" });
            users.Add(2, new User { Id = 2, Name = "Bob" });
            users.Add(3, new User { Id = 3, Name = "Charlie" });

            // 根据 ID 查找用户并输出其信息  
            if (users.ContainsKey(2))
            {
                User user = users[2];
                Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}


