//FarmAnimalManager.cs-农场动物管理系统
//要求：系统使用ArrayList存储动物列表，并提供一些基本操作，如添加动物、删除动物和显示动物列表
//知识点：ArrayList
using System.Collections;
#nullable disable

namespace Cha6ArrayListEx
{
    //动物类
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    //农场动物管理
    public class FarmAnimalManager
    {
        private ArrayList animalList;

        public FarmAnimalManager()
        {
            animalList = new ArrayList();
        }

        //添加
        public void AddAnimal(Animal animal)
        {
            animalList.Add(animal);
        }

        //移除
        public void RemoveAnimal(string name)
        {
            for (int i = 0; i < animalList.Count; i++)
            {
                Animal animal = (Animal)animalList[i];
                if (animal.Name == name)
                {
                    animalList.RemoveAt(i);
                    break;
                }
            }
        }

        //显示
        public void DisplayAnimals()
        {
            foreach (Animal animal in animalList)
            {
                Console.WriteLine("Name: " + animal.Name + ", Type: " + animal.Type);
            }
        }
    }
    //测试类
    class Program
    {
        static void Main()
        {
            FarmAnimalManager manager = new FarmAnimalManager();
            Animal dog = new Animal { Name = "旺财", Type = "狗" };
            Animal cat = new Animal { Name = "猫咪", Type = "猫" };
            manager.AddAnimal(dog);
            manager.AddAnimal(cat);
            manager.DisplayAnimals(); // 输出：Name: 旺财, Type: 狗, Name: 猫咪, Type: 猫  
            manager.RemoveAnimal("旺财"); // 删除名为"旺财"的动物  
            manager.DisplayAnimals(); // 输出：Name: 猫咪, Type: 猫  
        }
    }


}
