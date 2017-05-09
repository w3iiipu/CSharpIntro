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
        NullableType2();
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

} 
