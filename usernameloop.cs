using System;


namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

        int a;
        int b;
        a = 0;
        b = 0;

        {
                do
                {
                    Console.WriteLine("Username = {0}.", a);
                    Console.WriteLine("Password = {1}.", b);
                }
                while (a <= 10);
        }
    }
}
