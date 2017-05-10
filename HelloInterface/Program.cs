using System;

namespace HelloInterface
{
    public  class Program 
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print1();
            C1.Print2();

            //ICustomer1 C1 = new ICustomer1();       //Cannot create an instance if interface
            ICustomer1 Cust = new Customer();           //Customer is inheriting from interface chain
            Cust.Print1();
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

    public class Sample      //class cannot inherit from multiple class but can inherit multiple interface               
    {

    }
}
