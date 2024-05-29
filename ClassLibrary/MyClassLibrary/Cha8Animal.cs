namespace LhlClassLibrary
#nullable disable
{
    public class Animal
    {
        public Animal(string nn, int age)
        {
            this.NickName = nn;
            this.Age = age;
        }
        public void bark()
        { Console.WriteLine("animal can bark"); }
        public string NickName { get; set; }
        public int Age { get; set; }
    }
}
