using System;

namespace HelloProperties
{
    public class Program
    {
        public static void Main()
        {
            Student C1 = new Student();
            C1.Id = 101;                    //properties using set
            C1.Name = "John";
            //C1.PassMark = 34;               //eroor out since PassMakr is a read only field.

            Console.WriteLine("Student Id = {0}", C1.Id);       //properties using get
            Console.WriteLine("Student Name = {0}", C1.Name);
            Console.WriteLine("PassMark = {0}", C1.PassMark);
        }
    }

    public class Student
    {
        private string _name;
        private int _id;
        private int _passMark = 35;
        private string _city;

        public int Id //read and write properties
        {
            set //set access 
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be negativ");
                }
                this._id = Id;
            }
            get //get access
            {
                return this._id;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(Name))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = Name;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }

        public int PassMark //READ ONLY with get access
        {
            get
            {
                return this._passMark;
            }
        }

        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
            }
        }

        public string Email {get;set;} //auto implementing properties. private field is anonymously generated
          
    }
}