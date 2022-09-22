using System;
using System.Linq;

namespace LengthofLastWord58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LengthOfLastWord("   fly me   to   the moon  ");
        }

        public static int LengthOfLastWord(string s)
        {
            var str =  s.Trim().Split(" ");
            var newstr = str.Last();
            return str.Length;
        }
    }
}
