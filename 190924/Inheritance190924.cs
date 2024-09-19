using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo_180924._190924
{
    class ClassA
    {
        public static int staticVar = 123;
        public int x;
        public int y;
        public void methodA()
        {
            Console.WriteLine("methodA called..");
        }
      virtual  public void methodX()
        {
            Console.WriteLine("methodX from ClassA called..");
        }
    }
    class ClassB:ClassA
    {
        public int z;
        public void methodB()
        {
            Console.WriteLine("methodB called..");
        }
        public void methodX()
        {
            Console.WriteLine("methodX from ClassB called..");
        }
    }
    class ClassC:ClassA
    {
        public void methodC()
        {
            Console.WriteLine("methodC called..");
        }
    }
    internal class Inheritance190924
    {
    }
}
