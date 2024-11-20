using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Two_Pointers
{
    public class ValidPalindrome_125
    {
        public static bool IsPalindrome(string s)
        {
            var resultStr = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] <= 'z' && s[i] >= 'a') || (s[i] <= 'Z') && s[i] >= 'A' || (s[i] <= '9') && s[i] >= '0')
                {
                    stringBuilder.Append(s[i]);
                }
            }
            var result = stringBuilder.ToString().ToLower();
            stringBuilder.Clear();
            stringBuilder.Append(result.Reverse().ToArray());
            var isPalindrome = result == stringBuilder.ToString();
            return isPalindrome;
        }
    }
}