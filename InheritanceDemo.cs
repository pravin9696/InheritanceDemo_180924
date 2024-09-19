using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo_180924
{
    class AA
    {
        public AA():this(1)
        {
            Console.WriteLine("** default constructor of AA called....");
        }
        public AA(int x):this(10,20)
        {
            Console.WriteLine("** paramiterized constructor of AA called....");
        }
        public AA(int x,int y)
        {
            Console.WriteLine("** 2 parameter constructor of AA called....");
        }
        public void show()
        {
            Console.WriteLine("show from AA");
        }
    }
    class BB: AA
    {
        public BB()
        {
            Console.WriteLine("## default constructor of BB called....");
        }
        public BB(int b):base(897)
        {
            int p = 89;
            Console.WriteLine("## 1 parameter constructor of BB called....");
        }
        public void display()
        {
            Console.WriteLine("display from BB");
        }
     }
    class CC:BB
    {
        public CC()
        {
            Console.WriteLine("@@ default constructor of CC called....");
        }
        public CC(int c):base(c)
        {
            Console.WriteLine("@@ 1 parameter constructor of CC called....");
        }
        public void sum(int x,int y)
        {
            Console.WriteLine("sum="+(x+y));
        }
    }
   
    internal class InheritanceDemo
    {
    }
}
