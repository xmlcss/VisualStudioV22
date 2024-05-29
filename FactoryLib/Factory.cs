//Factory.cs--计算工厂类
#nullable disable
using System.Reflection;
namespace OperationLib
{
    public class Factory
    {
        public static Operation getOper(string type, int n1, int n2)
        {
            OperationLib.Operation oper = null;
            //动态获得程序集
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OperationLib.dll");
            Assembly ass = Assembly.LoadFile(path);
            //获得程序集中所有公开的数据类型
            Type type1 = ass.GetType("OperationLib.Operation");
            Type[] types = ass.GetExportedTypes();
            foreach (Type tt in types)
            {
                //判断当前数据类型是否是需要的数据类型
                if (tt.IsSubclassOf(type1))
                {
                    //创建子类对象，赋值给oper
                    //activator创建的是Object类型，所以要转换成Operation类
                   oper =( Activator.CreateInstance(tt, n1, n2)) as Operation;
                }
            }
            return oper;
        }
}
}
