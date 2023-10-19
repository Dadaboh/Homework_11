namespace Homework_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetInfo<MyClass>();
        }


        public static void GetInfo <T> () where T : class
        {
            var c = typeof (T).GetFields();

            Console.WriteLine("Public fields:\n");
            foreach ( var tmp in c)
            {
                Console.WriteLine(tmp.FieldType.ToString() + " - " + tmp.Name);
            }
            Console.WriteLine();

            c = typeof(T).GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static);

            Console.WriteLine("Private fields:\n");
            foreach (var tmp in c)
            {
                Console.WriteLine(tmp.FieldType.ToString() + " - " + tmp.Name);
            }
            Console.WriteLine();

            var constructors = typeof(T).GetConstructors();

            Console.WriteLine("Constructors:\n");
            foreach (var constructor in constructors)
            {
                var param = constructor.GetParameters();
                Console.WriteLine(constructor.DeclaringType + " - " + constructor.Name);
                Console.WriteLine("Parameters:");

                foreach (var tmp in param)
                {
                    Console.WriteLine("\t\t" + tmp.GetType() + " - " + tmp.Name);
                }
                Console.WriteLine();
            }

            var methods = typeof(T).GetMethods();

            Console.WriteLine("Methods:");
            foreach (var method in methods)
            {
                Console.WriteLine(method.ReturnParameter + " - " + method.Name);

                var param = method.GetParameters();

                Console.WriteLine("Parameters:");
                foreach (var tmp in param)
                {
                    Console.WriteLine("\t" + tmp.ParameterType + " - " + tmp.Name);
                }
                Console.WriteLine();
            }

            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                Console.WriteLine(property.GetType() + " - " + property.Name);
            }
            Console.WriteLine();

        }
    }



    public class MyClass
    {
        public int age;
        public string name;
        private string value;

        public bool isAlive { get; set; }

        public MyClass()
        {

        }
        public MyClass(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void myMethod()
        {

        }
        
        private void myMethod2()
        {

        }

    }
}