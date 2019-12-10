using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleUI
{
    public class basicPractice
    {
        public static int[] IndexOfCapitals(string str)
        {
            int i = 0;
            int j = 0;
            var temp = str.ToCharArray();
            int count = temp.Where(x => Char.IsUpper(x)).Count();
            int[] result = new int[count];
            foreach(char ch in str)
            {
                if(Char.IsUpper(ch))
                {
                    result[i] = j;
                    i++;
                }
                j++;
            }
            return result;
        }
        public static double[] FindLargest(double[][] values)
        {
            return values.Select(x => x.Max()).ToArray();

        }
        public static double[] UniqueSort(double[] arr)
        {
            return arr.OrderBy(x => x).Distinct().ToArray();
        }
        public static int Equal(int a, int b, int c)
        {
            if (a == b && b == c) return 3;
            else if ((a == b && b != c) || (a == c && b != c) || (c == b && b != a)) return 2;
            else return 0;
        }
        public static double[] CumulativeSum(double[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] += arr[i - 1];
            }
            return arr;

        }
        public static int MissingNum(int[] arr)
        {
            for (int i = 1; i < 11; i++)
                if (!arr.Contains(i))
                    return i;
            return 0;
        }
        public static double Mean(int[] arr)
        {
            int sum = 0;
            foreach(int a in arr)
            {
                sum += a;
            }
            return Math.Round((double)sum / arr.Length);
            
        }
        public static string AlphabetSoup(string str)
        {
            str.Replace("e","").Replace("i","").Replace("i", "").Replace("o", "").Replace("u", "");
            StringBuilder t = new StringBuilder() ;
            var temp = str.ToCharArray();
            Array.Sort(temp);
            foreach (char ch in temp) 
            t.Append(ch);
            return t.ToString();
        }
        public double sum(double a, double b)
        {
            return a + b;
        }
        public double divine(double a, double b)
        {
            return a / b;
        }
        public void swap(ref int a , ref int b)
        {
            var temp = a;
              a = b;
            b = temp;
            
        }

        public static bool hurdleJump(int[] hurdles, int jumpHeight)
        {
            foreach (int item in hurdles)
            {
                if (jumpHeight < item)
                    return false;
            }
            return true;

        }
        public static bool XO(string str)
        {
            int countX = 0;
            int countO = 0;
            foreach (char ch in str)
            {
                if (ch == 'x' || ch == 'X')
                    countX++;
                else if (ch == 'o' || ch == 'O')
                    countO++;
            }
            if (countO == countX)
                return true;
            return false;
        }
        public static string ReplaceVowels(string str, string ch)
        {
            StringBuilder result = new StringBuilder();
            foreach(char c in str)
            {
                if (c == 'e' || c == 'E' || c == 'u' || c == 'U' || c == 'i' || c == 'I' || c == 'O' || c == 'o' || c == 'a' || c == 'A')
                    result.Append(ch);
                else
                    result.Append(c);
            }
            return result.ToString();
        }
    }
}
