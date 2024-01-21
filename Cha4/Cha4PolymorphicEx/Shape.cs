//Shape.cs文件--图形类
//演示虚方法及虚方法重写

namespace Cha4PolymorphicEx
{
    /// <summary>
    /// Shape基类
    /// </summary>
    class Shape
    {
        protected int width, height;
        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int area()
        {
            return 0;
        }
    }

    ///rectangle 类
    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        { }
        public override int area()
        {
            Console.WriteLine("Rectangle area:");//长方形矩形
            return (width * height);
        }
    }

    ///triangle
    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int area()
        {
            Console.WriteLine("Triangle area:");
            return (width * height / 2);//三角形
        }
    }
}
