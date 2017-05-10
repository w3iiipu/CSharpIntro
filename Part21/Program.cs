using System;

namespace Part21
{
    public class Program
    {
        public static void Main()
        {
            /*
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Wei";
            FTE.LastName = "Oo";
            FTE.YearlySalary = 10000;
            FTE.PrintFullName();

            Employee PTE = new PartTimeEmployee();  //*3 PTE is employee type
            PTE.FirstName = "John";
            PTE.LastName = "Doe";
            ((Employee)PTE).PrintFullName();    //*2 type casting so the base class method is called
            */

            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();
            
            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }

        }
    }

    /* 1,2,3, are way to invole a hidden parent/base class member from the derived class*/

    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";
        public string Email;

        public Employee()           //parent class constructor 1
        {
            //Console.WriteLine("ParentClass Constructor Called");
        }

        public Employee(string Message) //overloaded parent clas construtor with parameter
        {
            Console.WriteLine(Message);
        }

        public virtual void PrintFullName()     //base class method marked as virtual to allow child class to override
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }

    public class FullTimeEmployee : Employee        // DereivedClass : ParentClass
    {
        public float YearlySalary;

        /*
        public FullTimeEmployee(): base ("Derived class controlling Parent Class")      
                                   //'base' allow child class to controll which parent class constructor is called
        {
            Console.WriteLine(FirstName + " " + LastName + " - Full Time");
        }
        */

        public override void PrintFullName()    //override the base class at run time
        {
            Console.WriteLine(FirstName + " " + LastName + " - Full Time");
        }

    }

    public class PartTimeEmployee :Employee
    {
        public float HourlyRate;

        public new void PrintFullName()     //'new' keyword here hides the overloaded method from parent class 
        {
            base.PrintFullName();           //*1 'base' keyword here used to make sure the child class method uses the parent class method inherited
            Console.WriteLine(FirstName + " " + LastName + " - Part Time");
        }
    }

    public class TemporaryEmployee :Employee
    {
        //if no override method then the base class method will be used instead
    }


    public class A :PartTimeEmployee
    {
        //multiple level inheritance. WIll inherit all of PTE as well as Employee class
    }
}
