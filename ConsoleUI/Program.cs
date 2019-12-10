using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a sentense:");
            string a = Console.ReadLine();
            Console.WriteLine("strat read from:");
            int start = Convert.ToInt16(Console.Read());
            Console.WriteLine("number of chars to read");
            int count = Convert.ToInt16(Console.Read());
            List<char> result = new List<char>();

            for (int i = start; i < (start + count); i++)
                result.Add(a[i]);

            foreach (char c in result)
                Console.WriteLine("{0}" , c);

            Console.Read();
        }
    }
}
