using System;
using System.Text;

namespace CharAndStringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var str = RemoveSpecialCharacters("0P");
            var result = ValidPalindrome(str);
            Console.WriteLine(result);
        }

        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder("");
            int count = 0;
            foreach (var item in str)
            {
                if (CheckIfValidCharacterORNot(str[count]))
                {
                    sb.Append(ToLower(str[count]));
                }
               
                count++;
            }
            return sb.ToString();
        }

        public static int Length(string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                count++;
            }
            return count;
        }

        public static char ToLower(char ch)
        {
            if ((ch >= 'a' && ch <= 'z' ) || (ch >= '0' && ch <= '9'))
            {
                return ch;
            }
            else
            {
                return (char)(ch - 'A' + 'a');
            }
        }

        public static char ToUpper(char ch)
        {
            if(ch  >= 'A' && ch <= 'Z')
            {
                return ch;
            }
            else
            {
                return (char)(ch - 'a' + 'A');
            }
        }

        public static bool CheckIfValidCharacterORNot(char ch)
        {
            if((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidPalindrome(string s)
        {
            if (s == " ") return true;

            int st = 0;
            int e = s.Length - 1;

            while (st < e)
            {

                if (s[st] !=s[e])
                {
                    return false;
                }

                st++;
                e--;

            }

            return true;
        }
    }
}
