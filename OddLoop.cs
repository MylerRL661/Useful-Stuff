using System;


namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

                for (int ctr = 1; ctr <= 10; ctr++)
                if (ctr % 2 != 0)
                {
                    Console.WriteLine("Number is {0}", ctr);
                    total = total + ctr;
                }

            Console.WriteLine("The total of the odd numbers is {0}", total);
        }


    }
}