using System;

namespace LongestCommonPrefix14
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestCommonPrefix(new string[] { "flower", "flow", "flight" });

        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = "";

            var str1 = strs[0];
            var str2 = strs[1];

            for (int i = 0; i < str1.Length; i++)
            {
                if (i < str2.Length)
                {
                    if (str1[i] == str2[i])
                    {
                        prefix += str1[i];
                    }
                }
            }

            for (int i = 2; i < strs.Length; i++)
            {
                if (!strs[i].Contains(prefix))
                {
                    return "";
                }
            }

            return prefix;



        }
    }
}
