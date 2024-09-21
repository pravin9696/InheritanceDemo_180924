namespace InheritanceDemo_180924.Multiple_inheritance_Demo
{
    interface I_MyInterface
    {
        //int x;//variable diclaration not allowed
        public int i { get; set; }
        public string myString { get; set; }
        public static int st1 = 11;
        public const float PI = 3.14f;

       public void show()
        {
            i = 1000;
            int x = i * 100;

            Console.WriteLine("this is my method");
        }
        void display();


    }
    public class Child1 : I_MyInterface
    {
       
        public string myString { get; set; }
        public int i { get; set; }
        public void display()
        {

        }
    }
    public class Child2 : I_MyInterface
    {
        public int i { get; set; }
        public string myString { get; set; }

        public void display()
        {

        }
    }
    abstract class abClass
    {
        public void show()
        {
            Console.WriteLine("show method from abstract class");
        }
       abstract public int sum(int x, int y);
    }
    class classXYZ : abClass
    {
        override public int sum(int x, int y)
        {
            return x + y;
        }
    }
    internal class multipleInheritanceDemo210924
    {
        public void method1()
        {
            classXYZ obj = new classXYZ();
            int p;
            p = obj.sum(100, 200);


        }
    }
}
