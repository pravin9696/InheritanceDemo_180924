using InheritanceDemo_180924._190924;
using System.Runtime.InteropServices.ObjectiveC;

namespace InheritanceDemo_180924
{
    class demo
    {
        public void primeUptoN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                bool flag = false;
                flag = isPrime(i);
                
                if(flag == true)
                {
                    Console.WriteLine($" {i} is not prime");
                }
                else
                {
                   // Console.WriteLine($"{i} is prime");
                }
            }
        }
        public bool isPrime(int n)
        {
            bool flag = false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //  AA objA = new AA();
            ////  //Console.WriteLine("-------------------");
            ////  //BB objB = new BB();
            ////  Console.WriteLine("-------------------");
            ////  CC obC = new CC(100);
            //////  obC.sum(1, 1);
            ///
            //------------------------------190924-----------------------------------

            //ClassA objA = new ClassA();
            //objA.x = 111;
            //objA.y = 222;
            //objA.methodA();

            ClassA objA = new ClassB();
            objA.methodX();
            
        }
    }
}
