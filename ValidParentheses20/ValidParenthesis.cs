using System;
using System.Collections.Generic;
using System.Text;

namespace ValidParentheses20
{
    public class ValidParenthesis
    {
        public static bool IsValid(string s)
        {
            bool isValid = false;
            for (int i = 0; i < s.Length; i++)
            {
                isValid = false;
                if (i + 1 == s.Length) break;
                var symbol = Convert.ToString(s[i]);
                var nextSymbol = Convert.ToString(s[i + 1]) ?? null;
                if (symbol == "(" && nextSymbol == ")")
                {
                    isValid = true;
                }
                if (symbol == "{" && nextSymbol == "}")
                {
                    isValid = true;
                }
                if (symbol == "[" && nextSymbol == "]")
                {
                    isValid = true;
                }

            }

            return isValid;
        }
    }
}
