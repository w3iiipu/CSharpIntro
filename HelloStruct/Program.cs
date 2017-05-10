using System;

namespace HelloStruct
{
    public class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer(101, "John");    //*1 constructor with parameters
            C1.PrintDetails();

            Customer C2 = new Customer();               //*2 default constructor using properties to initialized details
            C2.ID = 102;
            C2.Name = "Bob";
            C2.PrintDetails();

            Customer C3 = new Customer                  //*3 object initializer sytax
            {
                ID = 103,
                Name = "Tom"
            };
            C3.PrintDetails();
        }
    }

    public struct Customer
    { 
        private int _id;
        private string _name;

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name { get => _name; set => _name = value; }

        public Customer(int Id, string Name)
        {   
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
        }

    }
}
