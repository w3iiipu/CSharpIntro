using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDelegatees
{
    public delegate void HelloFunctionDelegate(string Message);

    class Program
    {
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        static void Main(string[] args)
        {
            //delegate is a type safe(signature of method must match) function pointer
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 1000, Experience = 2 });
            empList.Add(new Employee() { ID = 102, Name = "John", Salary = 2000, Experience = 3 });
            empList.Add(new Employee() { ID = 103, Name = "Bob", Salary = 5000, Experience = 6 });
            empList.Add(new Employee() { ID = 104, Name = "Tom", Salary = 4000, Experience = 5 });

            //----------------------------------------------------------------------------------------------------------

            IsPromotable isPromotable = new IsPromotable(Promote);      //*3 create instance of delegate and pass name of function

            Employee.PromoteEmployee(empList, isPromotable);            //*4 


            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);      //same thing as *1-*4 but using lambda
        }

        public static bool Promote(Employee emp)        //*2 create method - must match signature
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    delegate bool IsPromotable(Employee empl);          //*1 create delegate

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }
}
