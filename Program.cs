using InheritanceDemo_180924._190924;
using InheritanceDemo_180924.InheritanceEXampleSolution;
using InheritanceDemo_180924.Multiple_inheritance_Demo;
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

            //ClassA objA = new ClassB();
            //objA.methodX();

            //  Truck tr = new Truck("TATA", 123, 100, 500, 10, 15);
            //  tr.display();
            //  Console.WriteLine("-------------");
            //  int dis = 200;
            //int fn=  tr.fuelNeeded(dis);
            //  Console.WriteLine($" Fuel needed for {dis}KM is {fn} Litre");
            //  tr.distanceCovered(5);

            I_MyInterface Inter1 = new Child1();
            
            Child1 c1 = new Child1();
            //c1.show();
        }
    }
}
