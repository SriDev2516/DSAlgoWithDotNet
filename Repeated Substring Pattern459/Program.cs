using System;

namespace Repeated_Substring_Pattern459_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatedSubstringPattern("abaababaab"));
        }

        public static bool RepeatedSubstringPattern(string s)
        {
            int repeatedStringLength = 0;
            var firstChar = s[0];
           
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == firstChar)
                {
                    repeatedStringLength = i;
                    break;
                }
              
            }

            
            var result = s.Replace(s.Substring(0, repeatedStringLength), "");

            return result == "" ? true : false;
           

           
        }
    }

    
}
