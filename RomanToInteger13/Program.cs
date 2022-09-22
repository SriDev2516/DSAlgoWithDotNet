using System;
using System.Collections.Generic;

namespace RomanToInteger13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "LIV";
            int result = RomanToIntSolution(s);
        }

        public static int RomanToIntSolution(string s)
        {
            int sum = 0;
            var romanDict = new Dictionary<char, int>();
            romanDict.Add('I', 1);
            romanDict.Add('V', 5);
            romanDict.Add('X', 10);
            romanDict.Add('L', 50);
            romanDict.Add('C', 100);
            romanDict.Add('D', 500);
            romanDict.Add('M', 1000);

            int previousNumber = 0;
            for (int i = s.Length-1; i >= 0; i--)
            {
                int number = romanDict[s[i]];
                if(number >= previousNumber)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;  
                }

                previousNumber = number;
            }

            return sum;
        }
        public static int RomanToInt(string s)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("I", 1);
            d.Add("V", 5);
            d.Add("X", 10);
            d.Add("L", 50);
            d.Add("C", 100);
            d.Add("D", 500);
            d.Add("M", 1000);
            d.Add("IV", 4);
            d.Add("IX", 9);
            d.Add("XL", 40);
            d.Add("XC", 90);
            d.Add("CD", 400);
            d.Add("CM", 900);


            int result = 0;
            int left = 0;
            int right = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (left >= s.Length) { return result; }
                var c = s[left].ToString() + (right < s.Length ? s[right].ToString() : "");
                if (d.ContainsKey(c))
                {
                    result += d[c];
                    left = left + 2;
                    right = right + 2;
                }
                else
                {
                    result += d[s[left].ToString()];
                    left++;
                    right++;
                }


            }



            return result;
        }
    }
}
