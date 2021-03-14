using System;


namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Can i sleep yet?";
            string newString = "";
            int count = 0;

            foreach (char myChar in myString)
            {
                if (myChar == ' ')
                    continue;

                newString += myChar;
            
            
                Console.WriteLine("myString[" + count + "] = " + myChar);
                count++;
            }
        }
    }
}
