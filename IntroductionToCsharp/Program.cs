using System;

class Program
{

    static void Main1()
    {

        Console.WriteLine("Hello");
    }

    static void Main()
    {
        Console.WriteLine("Welcome to C# Training");
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
        //SampleClass.CoffeeSwitch();
        //SampleClass.CoffeeSwitchDoWhile();
        //SampleClass.CoffeeSwitchDoWhile2();
        //SampleClass.DoWhileLoop();
        //SampleClass.HelloLoops();

        /*
        SampleClass user = new SampleClass();                       //instance method by creating an object of the class.
        string UserName = user.GetName("John", "Doe");
        Console.WriteLine(UserName);
        */

        //SampleClass.HelloStaticMethods();                         //static method

        /*
        int i = 0;                                         
        SampleClass.SimpleMethod(ref i);                            //pass by reference
        Console.WriteLine(i);
        */

        /*
        int Total = 0;
        int Product = 0;
        SampleClass.Calculate(10, 20, out Total, out Product);      //out parameters
        Console.WriteLine("The Sum is {0} and Product is {1}", Total, Product);
        */

        //SampleClass.ParamsMethod();
        //SampleClass.ParamTestArrays();
        //SampleClass.ParamsMethod(1, 2, 3, 4, 5);                  //method arguments when you invoke, method parameters when you declare



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

        public static void CoffeeSwitch()
        {
            int ItemTotal = 0;
            string UserCont = "";

            Start:
            Console.WriteLine("1 - Small, 2- Medium, 3 - Large");
            int UserInput = int.Parse(Console.ReadLine());

            switch (UserInput)
            {
                case 1:
                    ItemTotal += 1;
                    break;
                case 2:
                    ItemTotal += 2;
                    break;
                case 3:
                    ItemTotal += 3;
                    break;
                default:
                    Console.WriteLine("{0} is an invalid selection", UserInput);
                    goto Start;
            }

            Decide:
            Console.WriteLine("Do you want to buy another coffee - Yes or No?");
            UserCont = Console.ReadLine().ToLower();

            switch (UserCont)
            {
                case "yes":
                    goto Start;
                case "no":
                    break;
                default:
                    Console.WriteLine("{0} is an invalid option! Please try again!", UserCont);
                    goto Decide;
            }

            Console.WriteLine("Your Item Total is $ {0}", ItemTotal);
        }

        public static void CoffeeSwitchDoWhile()
        {
            string UserCont = "";
            int ItemTotal = 0;
            int GrandTotal = 0;

            do
            {
                Console.WriteLine("1 - Small, 2- Medium, 3 - Large");
                int UserInput = int.Parse(Console.ReadLine());

                switch (UserInput)
                {
                    case 1:
                        ItemTotal += 1;
                        break;
                    case 2:
                        ItemTotal += 2;
                        break;
                    case 3:
                        ItemTotal += 3;
                        break;
                    default:
                        Console.WriteLine("{0} is an invalid selection", UserInput);
                        break;
                }

                Console.WriteLine("Please enter quantity: ");
                int UserQuantity = int.Parse(Console.ReadLine());
                GrandTotal = ItemTotal * UserQuantity;

                Console.WriteLine("Your Item Total is $ {0}. Your Grand Total is $ {1}", ItemTotal, GrandTotal);
                do
                {
                    Console.WriteLine("Do you want to buy another coffee - Yes or No?");
                    UserCont = Console.ReadLine().ToLower();
                    if (UserCont != "yes" && UserCont != "no")
                    {
                        Console.WriteLine("Please enter yes or no.");
                    }

                } while (UserCont != "yes" && UserCont != "no");
            } while (UserCont == "yes");
        }

        public static void CoffeeSwitchDoWhile2()
        {
            string UserCont = string.Empty;
            int ItemTotal = 0;
            int GrandTotal = 0;

            do
            {
                int UserInput = -1;
                do
                {
                    Console.WriteLine("1 - Small, 2- Medium, 3 - Large");
                    UserInput = int.Parse(Console.ReadLine());

                    switch (UserInput)
                    {
                        case 1:
                            ItemTotal += 1;
                            break;
                        case 2:
                            ItemTotal += 2;
                            break;
                        case 3:
                            ItemTotal += 3;
                            break;
                        default:
                            Console.WriteLine("{0} is an invalid selection", UserInput);
                            break;
                    }

                    Console.WriteLine("Please enter quantity: ");
                    int UserQuantity = int.Parse(Console.ReadLine());
                    GrandTotal = ItemTotal * UserQuantity;

                } while (UserInput != 1 && UserInput != 2 && UserInput != 3);

                do
                {
                    Console.WriteLine("Do you want to buy another coffee - Yes or No?");
                    UserCont = Console.ReadLine().ToLower();
                    if (UserCont != "yes" && UserCont != "no")
                    {
                        Console.WriteLine("Please enter yes or no.");
                    }
                } while (UserCont != "yes" && UserCont != "no");
            } while (UserCont != "no");

            Console.WriteLine("Thank you for shopping. Your Grandtotal is $ {0}", GrandTotal);
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

        public static void HelloStaticMethods()
        {
            Console.WriteLine("Hello World");
        }

        public string GetName(string FN, string LN)
        {
            return FN + " " + LN;
        }

        public static void SimpleMethod(ref int j)       //reference parameters - pass by reference - point to the same memory location, j will modify the original refernece i
        {
            j = 101;
        }

        public static void Calculate (int i, int j, out int Sum, out int Product) //out parameters
        {
            Sum = i + j;
            Product = i * j;
        }

        public static void ParamTestArrays()
        {
            int[] Numbers = { 101, 102, 103 };

            ParamsMethod(Numbers);
        }

        public static void ParamsMethod(params int[] Numbers)               //Only one parameter arrays and must be the last keyword parameter
        {
            Console.WriteLine("there are {0} elements", Numbers.Length);

            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }

    }






