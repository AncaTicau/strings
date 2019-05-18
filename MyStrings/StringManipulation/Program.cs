using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = " Ana are mere! ";

            Console.WriteLine($"index of a : {myString.IndexOf('a')}");

            Console.WriteLine($"last index of e : {myString.LastIndexOf('e')}");

            //string mere = myString.Substring(0);

            string mere = myString.Substring(9, 4);

            string mere2 = myString.Substring(myString.IndexOf('m'), 4);

            Console.WriteLine(mere);

            Console.WriteLine(mere2);


            string cleanedString = myString.Trim();

            Console.WriteLine(cleanedString);


            string cleanedStringStart = myString.TrimStart();

            Console.WriteLine(cleanedStringStart);


            string replacedString = myString.Replace(" ", ".");

            Console.WriteLine(replacedString);

            string replaceA = myString.Replace("a", "!", true, new CultureInfo("en-us"));

            Console.WriteLine(replaceA);

            //split

            var splitted = myString.Trim().Split(new char[] { ' ' });

            for (int i = 0; i < splitted.Length; i++)
            {
                Console.WriteLine(splitted[i]);
            }

            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.ToUpper());

            Console.WriteLine(myString.Remove(9, 4));

            //concatenation

            string concatenated = "";

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 100; i++)
            {
                concatenated = concatenated + i.ToString();

                //v2

                //concatenated += i.ToString();
            }

            timer.Stop();

            //Console.WriteLine(concatenated);
            Console.WriteLine(timer.Elapsed);


            StringBuilder stringBuilder = new StringBuilder();

            Stopwatch timerForBuilder = new Stopwatch();
            timerForBuilder.Start();

            for (int i = 0; i < 100; i++)
            {
                stringBuilder.Append(i.ToString());
            }

            timerForBuilder.Stop();

            //Console.WriteLine(stringBuilder);

            Console.WriteLine(timerForBuilder.Elapsed);
        }
    }
}
