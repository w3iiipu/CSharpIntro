using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    /// <summary>
    /// c# does not support multiple class inheritance as it creates the diamond problem. 
    /// However it is possible to have multiple class inheritance thru interface
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.AMethod();       //now able to call method from each class without reimplemneting method in AB class
            ab.BMethod();
        }
    }

    interface IA
    {
        void AMethod();
    }

    class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }

    interface IB
    {
        void BMethod();
    }

    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }

    //class AB : A, B { } not possible

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void AMethod()
        {
            //Console.WriteLine("A");
            a.AMethod();                //not providing implementation but using implementatin provided by A class
        }

        public void BMethod()
        {
            //Console.WriteLine("B");
            b.BMethod();
        }
    }

}
