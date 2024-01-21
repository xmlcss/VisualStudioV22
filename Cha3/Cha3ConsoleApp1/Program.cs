namespace Cha3ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            #region:枚举示例    
            // Orientation myDirection = Orientation.north;
            // Console.WriteLine("my direction is {0}", myDirection);
            #endregion

            #region:结构示例
            Route myRoute;
            int myDirection = -1;
            double myDistance;
            Console.WriteLine("select a  direction:");
            myDirection = Convert.ToInt32(Console.ReadLine());//设置方向
            Console.WriteLine("input a distance:");
            myDistance = Convert.ToDouble(Console.ReadLine());//设置距离

            myRoute.direction = (Orientation)myDirection;//赋值
            myRoute.distance = myDistance;
            Console.WriteLine("my route specifies a direction of {0} and a distance of {1}", myRoute.direction, myRoute.distance);
            #endregion
        }
        enum Orientation//枚举声明，成员变量
        {
            north = 1,
            south = 2,
            east,
            west
        }
        struct Route
        {
            public Orientation direction;//public关键字不能省
            public double distance;
        }


    }
}
