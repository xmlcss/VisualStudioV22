//PlantingTrees.cs--蚂蚁森林种树模拟
/*需求描述-------------------------------------------------------------------------------------------------------------------------------------------------
 * 蚂蚁森林是支付宝客户端为首期"碳账户"设计的一款公益行动：
 * 用户通过步行、地铁出行等行为，就会减少相应的碳排放量，可以用来在支付宝里养一棵虚拟的树。
 * 这棵树长大后，公益组织、环保企业等蚂蚁生态伙伴们，可以“买走”用户在蚂蚁森林里种植的虚拟“树”，而在现实某个地域种下一棵实体的树。
 *---------------------------------------------------------------------------------------------------------------------------------------------------------*/
//知识点：泛型方法，类型约束
#nullable disable
namespace GenericExApp
{
    //树基类
    public abstract class TreeBase
    {
        public abstract string GetTreeName();
        public abstract int NeedEnergy();
    }
    //柠条树
    public class NingtiaoTree : TreeBase
    {
        public override int NeedEnergy()
        {
            return 16930;
        }
        public override string GetTreeName()
        {
            return ("NingTiaoTree");
        }
    }
    //梭梭树
    public class SuosuoTree : TreeBase
    {
        public override int NeedEnergy()
        {
            return 17900;
        }
        public override string GetTreeName()
        {
            return ("SuoSuoTree");
        }
    }

    //people类 
    public class People
    {
        //姓名
        public string Name { get; set; }
        //能量
        public int Energy { get; set; }

        //种树
        public void Plant<T>(T tree) where T : TreeBase
        {
            if (Energy < tree.NeedEnergy())
            {
                Console.WriteLine("not enough energy");
            }
            else
            {
                Energy = Energy - tree.NeedEnergy();
                Console.WriteLine($"Congratulation!  {Name} ! the success of {tree.GetTreeName()} planting");
            }
        }
    }

    //测试类
    public class Test
    {
        static void Main(string[] args)
        {
            People zhangsan = new People()
            {
                Name = "zhangsan",
                Energy = 200000
            };
            zhangsan.Plant(new NingtiaoTree());
            zhangsan.Plant(new SuosuoTree());
            Console.WriteLine("your residual energy is " + zhangsan.Energy);
            Console.ReadKey();
        }

    }
}
