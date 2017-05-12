using System;

namespace HelloInterface
{
    public  class Program :I1, I2
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print1();
            C1.Print2();

            //ICustomer1 C1 = new ICustomer1();       //Cannot create an instance if interface
            ICustomer1 Cust = new Customer();           //Customer is inheriting from interface chain
            Cust.Print1();

            Sample s = new Sample();

            Program p = new Program();
            p.InterfaceMethod();            //**default implementation
            ((I2)p).InterfaceMethod();              //**explicit type casting interface method 

            I1 i1 = new Program();                  //alternative  way to type cast interface methods
            I2 i2 = new Program();
        }

        public void InterfaceMethod()      //**public for default interface implementation        
        {   
            Console.WriteLine("I1 Interface");
        }

        void I2.InterfaceMethod()                   //**explicit implementation cannot use access modifier i.e. public  
        {
            Console.WriteLine("I2 Interface");
        }

    }

    interface ICustomer1         //NO explicit access modifiers
    {
        void Print1();           //interface member public by default, and can only have declaraion, NO implementation
    }                           //implementation will cause run time error

    interface ICustomer2 :ICustomer1
    {
        void Print2();
    }

    

   public  class Customer : ICustomer2  //the class implements a interface chain must provides all implementations 
    {
        public void Print2()      //class implementing multiple interface
        {
            Console.WriteLine("Print2");
        }

        public void Print1()
        {
            Console.WriteLine("Print1");
        }
    }

    /// <summary>
    /// why kenot inherit interface 1?
    /// </summary>
    public class Sample : ICustomer1  //class cannot inherit from multiple class but can inherit multiple interface               
    {
        public void Print1()
        {
            Console.WriteLine("ICsutomer1 methd");
        }
    }


    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }
}
