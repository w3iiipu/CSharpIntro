using System;
using System.IO;

namespace HelloException
{
    class Program
    {
        public static void Main()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\GitHub\HelloException\data.txt");     //@ to escape backslash
                Console.WriteLine(streamReader.ReadToEnd());

            }
            catch (FileNotFoundException ex)             //more specific exception on top
            {

                //Console.WriteLine(ex.Message);
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);

                Console.WriteLine("Please check file {0}", ex.FileName);
            }
            catch (Exception ex)                    //catch all block/general at the end
            {
                Console.WriteLine(ex.Message);
            }
            finally                                 //release resources after exception handling
            {
                if (streamReader != null)
                {
                    streamReader.Close();              //close streamreader
                    Console.WriteLine("Finally block executed");
                }
            }
        }
    }
}
