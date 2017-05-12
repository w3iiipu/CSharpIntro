using System;

namespace AbstratvsInterface
{
    class Program           //class cannot inherit from multiple class but can inherit from multiple interfaces
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Customer
    {
        /* 
         * can inherit from abstract class or interface
         */

        int ID = 0;                         //can have fields

        public void print()                 //private by default, can have access modifiers. can have non abstract method
        {
            Console.WriteLine("print");     //can have implementation for non abstract members
        }
    }

    interface ICustomer                     //public by default and kcannot use access modifiers
    {
        /*
         * can inherit from another interface only
         */ 

        //int id =  0;                      //canot have fields
        void print();                       //cannot have implementations
    }
}
