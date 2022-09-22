using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterCombinationsOfAPhoneNumber17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var digits = "2";
            LetterCombinations(digits);
        }

        public static IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0) return new string[0];
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("2", "abc");
            d.Add("3", "def");
            d.Add("4", "ghi");
            d.Add("5", "jkl");
            d.Add("6", "mon");
            d.Add("7", "pqrs");
            d.Add("8", "tuv");
            d.Add("9", "wxyz");

            List<string> list = new List<string>();
            var data = new string[4];

            for (int i = 0; i < digits.Length; i++)
            {
                var num = digits[i];
                data[i] = d[num.ToString()];
            }



            for (int i = 1; i < data.Length; i++)
            {
                if (data.Length == 1) return data.ToArray().ToList<string>();
                if (data[i] == null) break;
                
                var first = data[0];
                var second = data[i];
                if (first.Length >= second.Length)
                {
                    CrossJoin(first, second, list);
                }
                else
                {
                    CrossJoin(second, first, list);
                }
            }

            return list;


        }

        public static void  CrossJoin(string first, string second, List<string> list)
        {
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    list.Add(first[i].ToString() + second[j].ToString());
                }
            }


        }
    }
}
