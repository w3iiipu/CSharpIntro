using System;

namespace Part20
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle C1 = new Circle(5);
            float Area = C1.CalculateArea();
            Console.WriteLine("Area = {0}", Area);
            

            Circle C2 = new Circle(6);
            float Area2 = C2.CalculateArea();
            Console.WriteLine("Area = {0}", Area2);

        }
    }

    class Circle
    {
        static float _PI;
        int _Radius;

        public Circle (int Radius)          //without access modifier private is default
        {
            Console.WriteLine("Instance Constructor Called");
            this._Radius = Radius;
        }

        static Circle()                     //staic constructor does not need to be call explicitly and no access modifier
        {
            Console.WriteLine("Static Constructor Called");
            Circle._PI = 3.141F;
        }

        public float CalculateArea()        //instance member- call by object in class
        {
            return _PI * this._Radius * this._Radius;
        }

        public static void Print()          //static - call by class
        {

        }
    }
}
