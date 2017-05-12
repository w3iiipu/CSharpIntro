using System;

namespace HelloAbstract
{
    /*
     * 1. provide implementation for all abstract members
     * 2.if not providing implemntation for all abstract class, class must be marked as abstract
     */
     
    public class Program : Customer             //non abstract class must provide implementation for all abstract class
    {
        public override void Print()            //providing implementation for abstract method - use override method
        {
            Console.WriteLine("Print Method");
        }

        public void Main(string[] args)
        {
            Program P = new Program();      //createing class object
            P.Print();

            Customer C = new Program();     //or create object from an abstract reference
            P.Print();


        }
    }

    //abstrat cannot be seal  - can only be a base class
    public abstract class Customer               //cannot be instantiated - cannot create a object of customer
    {
        public abstract void Print();           //Cannot have implementation

        public void print2()
        {
            //can also have other members not abstract
        }
     
    }

}
