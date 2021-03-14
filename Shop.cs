using System;


namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;

            Random rnd = new Random();
            for (x = 1, y = 1, z = 1; x + y + z <100; x++, y++, z++)
            {
                number1 = rnd.Next(1, 101);
                number2 = rnd.Next(1, number1);
                number3 = rnd.Next(1, number1 + number2);

                Console.WriteLine("Item {0} is {1}", x, number1);
                Console.WriteLine("Item {0} is {1}", y, number2);
                Console.WriteLine("Item {0} is {1}", z, number3);
            }
            Console.ReadLine();
            
            
        }
    }
}
