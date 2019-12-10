using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public sealed class Signelton
    {
        private static int counter = 0;
        private static Signelton Instance = null;
        public static Signelton newInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Signelton();                 
                }
                return Instance;
            }
        }
        private Signelton()
        {
            counter++;
            Console.WriteLine($"counter = {counter}");
        }
        public void printDetails(string massage)
        {
            Console.WriteLine(massage);
        }
    }
}
