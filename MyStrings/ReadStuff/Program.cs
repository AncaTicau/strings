using System;

namespace ReadStuff
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter a string");

            string readedLine = Console.ReadLine();

            Console.WriteLine("Please enter a second string");

            string readedLine2 = Console.ReadLine();

            if (readedLine == readedLine2)
            {
                Console.WriteLine("They are the same");
            }

            //Compare

            Console.WriteLine(string.Compare(readedLine, readedLine2, true));

            if (readedLine.Equals(readedLine2))
            {
                Console.WriteLine("equals");
            }

            //Console.WriteLine(readedLine.Length/2F);

        }
    }
}
