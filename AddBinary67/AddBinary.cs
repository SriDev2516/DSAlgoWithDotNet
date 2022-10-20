using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddBinary67
{
    public class AddBinary
    {
        public string AddBinaryFunc(string a, string b)
        {
            StringBuilder res = new StringBuilder();
            int i = a.Length - 1;  // we crete i pointer for string a and we have to start adding from right to left 
            int j = b.Length - 1;
            int carry = 0;

            // Now, we subtract by '0' to convert the numbers from a char
            // type into an int, so we can perform operations on the numbers
            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (i >= 0) sum += a[i--];
                if (j >= 0) sum += b[j--];
                carry = sum > 1 ? 1 : 0;
                res.Append(sum % 2);
            }
            if (carry != 0) res.Append(carry);
            var arr = res.ToString().ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
