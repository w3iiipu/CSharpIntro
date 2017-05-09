using System;

class Program
{

    static void Main1()
    {

        Console.WriteLine("Welcome to C# Training");
    }

    static void Main()
    {
        Console.WriteLine("Hello");
        //Main1();
        //UserName();
        //DataTypes();
        //StringTypes();
        //Operators();
        //NullableType();
        //NullableType2();
        //TypeCasting();
        //TestArrays();
        //SampleClass.HelloWorld();
        //SampleClass.HelloSwitch();
        //SampleClass.DoWhileLoop();
        SampleClass.HelloLoops();
    }

    static void UserName()
    {
        Console.WriteLine("Please Enter your first name");
        String UserFirstName = Console.ReadLine();
        Console.WriteLine("Please Enter your last name");
        String UserLastName = Console.ReadLine();

        //Console.WriteLine("Hello " + UserName);                           //Concatenate

        Console.WriteLine("Hello {0} {1}", UserFirstName, UserLastName);   //Place holder syntax
    }

    static void DataTypes()
    {
        int i = 12;

        Console.WriteLine("Min = {0} + {1}", int.MinValue, i);

        double d = 123.123456789;
        Console.WriteLine(d);

    }

    static void StringTypes()
    {
        string Name = "\"Wei\"";                            //Escape sequence '\' '\n' '\\'
        Console.WriteLine(Name);

        string Numbers = "One\nTwo\nThree";                 //new line by escaping \n
        Console.WriteLine(Numbers);

        string Backslash = "C:\\Program\\CSharp\\Project";  //Escaping blackslash with another backslash
        Console.WriteLine(Backslash);

        string Backslash2 = @"C:\Program\CSharp\Project";   //Verbatim Literal with @ when string doesn't need to be escaped
        Console.WriteLine(Backslash2);

    }

    static void Operators()
    {
        int Number = 15;

        bool IsNumber10 = Number == 10 ? true : false;      //Ternary Operator after '?' is true, after ':' is false

        Console.WriteLine("Number == 10 is {0}", IsNumber10);
    }

    static void NullableType()
    {
        int? TicketOnSale = null;                       //nullable

        int AvailableTickets;                           //non nullable

        if (TicketOnSale == null)
        {
            AvailableTickets = 0;
        }
        else
        {
            AvailableTickets = (int)TicketOnSale;       //Converting nullable type to non nullable type by casting it
        }

        Console.WriteLine("AvailableTickets = {0}", AvailableTickets);
    }

    static void NullableType2()
    {
        int? TicketOnSale = null;                       //Nullable

        int AvailableTickets = TicketOnSale ?? 0;       //null coalescing operator ?? (if TicketOnSale is Null then use 0 or else use value of TicketOnSale)

        Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

    }

    static void TypeCasting()
    {
        float f = 12345.123F;

        int i = (int)f;                                 //explicit casting from float to int using operator (). Will not thorw exception

        int j = Convert.ToInt32(f);                     //explicit casting using the convert class. Will throw exception

        Console.WriteLine(i + " " + j);

        string StrNum = "100";
        int k = int.Parse(StrNum);                      //when sure about conversion otherwise use tryparse.
        Console.WriteLine(k);

        string StrNum2 = "100try";
        int result = 0;
        bool IsConversionSuccessful = int.TryParse(StrNum2, out result);    //also returns a bool if conversion is successful or not
        if (IsConversionSuccessful)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }

    }

    static void TestArrays()
    {
        int[] EvenNum = new int[3];
        EvenNum[0] = 2;
        EvenNum[1] = 4;
        EvenNum[2] = 6;

        int[] OddNum = { 1, 3, 5 };

        Console.WriteLine(EvenNum[1]);
        Console.WriteLine(OddNum[2]);
    }

    /// <summary>
    /// This XML comment will document what the class is used for
    /// </summary>
    class SampleClass
    {
        public static void HelloWorld()
        {
            Console.WriteLine("hellow World");
        }

        public static void HelloSwitch()
        {
            Console.WriteLine("Please enter a number: ");
            int UserInput = int.Parse(Console.ReadLine());

            switch (UserInput)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Your number is between 1-4");
                    break;
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("Your number is between 11-13");
                    break;
                default:
                    Console.WriteLine("Your number is irrelevant");
                    break;

            }
        }

        public static void DoWhileLoop()
        {
            string UserCont = "";

            do
            {
                Console.WriteLine("Please enter a target nuber: ");
                int UserInput = int.Parse(Console.ReadLine());
                int start = 0;

                while (start <= UserInput)
                {
                    Console.Write(start + " ");
                    start = start + 2;
                }

                do
                {
                    Console.WriteLine("Do you want to continue? Yes or No");
                    UserCont = Console.ReadLine().ToLower();
                    if (UserCont != "yes" && UserCont != "no")
                    {
                        Console.WriteLine("Please input a valid selection. Yes or No.");
                    }
                } while (UserCont != "yes" && UserCont != "no");
            } while (UserCont == "yes");
        }

        public static void HelloLoops()
        {
            int[] Numbers = { 101, 102, 103 };

            foreach (int i in Numbers)                  //loops all in the collection
            {
                Console.WriteLine(i);
            }

            for (int j = 0; j < Numbers.Length; j++)    //loops when we know # of iteration
            {
                Console.WriteLine(Numbers[j]);
            }

            for (int k = 0; k <= 20; k++)
            {
                if (k % 2 == 1)
                    continue;                           //skips following execution and goes back to loop.

                Console.WriteLine(k);
            }
        }

        public static void HelloMethods()
        {

        }
    }




}
