using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString1 = "Well";
            string myString2 = "He";
            myString2 += "llo";
            string myString3 = myString1 + myString2;

            Console.WriteLine(myString3);
            Console.ReadLine();
        }
    }
}
