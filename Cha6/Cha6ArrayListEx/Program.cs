using System.Collections;
 
namespace Cha6ArrayListEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            //添加数据
            al.Add(123);
            al.Add("program");
            al.Add(456);

            //修改数据
            al[2] = 666;
            //移除数据
            al.RemoveAt(0);
            //插入数据
            al.Insert(0, "net");
         }
    }
}
