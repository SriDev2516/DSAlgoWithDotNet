using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSingleNumbers
{
    public class Class1
    {
        //Given a string of round, curly and square open and closing brackets, return whether the brackets are balanced(well-formed)
        //For example, Given the string “([])[] ({})”, you should return true. Given the string “([)]” or “((()”, you should return false.



        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    st.Push(s[i]);
                }
                else
                {
                    if (st.Count == 0) return false;
                    var top = st.Peek();

                    if ((top == '(' && s[i] == ')') || (top == '{' && s[i] == '}') || (top == '[' && s[i] == ']')) st.Pop();
                    else
                        return false;
                }
            }

            return st.Count == 0;
        }
    }
}
