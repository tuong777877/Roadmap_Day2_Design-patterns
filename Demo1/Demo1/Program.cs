namespace Demo1
{
   interface IClassC
    {
        public void ActionC();
    }
    interface IClassB
    {
        public void ActionB();
    }
    class ClassC : IClassC
    {

        public void ActionC() => Console.WriteLine("Action in ClassC");
    }

    class ClassB : IClassB
    {
        public void ActionB()
        {
            Console.WriteLine("Action in ClassB");
            ClassC c = new ClassC();
            c.ActionC();
        }
    }

    class ClassA
    {
        public void ActionA()
        {
            Console.WriteLine("Action in ClassA");
            ClassB b = new ClassB();
            b.ActionB();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            ClassC objectC = new ClassC();
            ClassB objectB = new ClassB();
            ClassA objectA = new ClassA();

            objectA.ActionA();

        }
    }
}