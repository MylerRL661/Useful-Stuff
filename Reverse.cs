using System;


namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string inString = "edud huS", outString = "";

            foreach (char c in inString)
            {
                outString = c + outString;
            }
            Console.WriteLine("The Reverse String is: " + outString);
            Console.ReadLine();
        }
    }
}
