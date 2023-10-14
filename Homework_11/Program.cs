namespace Homework_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var o = new MyClass();

            ASD(o.GetType());


        }


        public static void ASD(Type type)
        {

        }
    }



    public class MyClass
    {
        public int age;
        public string name;

        public bool isAlive { get; set; }

        public MyClass()
        {

        }
        public MyClass(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

    }
}