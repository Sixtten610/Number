using System;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                Console.WriteLine("Write number:");
                string s = Console.ReadLine();

                // försöker konvertera stringen från consolreadline till en int;    
                bool convert = int.TryParse(s, out number);
                // om convert skriv success meddelande
                if (convert)
                {
                    System.Console.WriteLine("nice " + number + " is a number!");
                }
                // om inte ge instruktioner hur man går tillväga
                else
                {
                    System.Console.WriteLine(s + " does not work, try a number i.e: '2'");
                }

            }
        }
    }
}
