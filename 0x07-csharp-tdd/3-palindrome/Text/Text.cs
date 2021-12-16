using System;
using System.Text.RegularExpressions;

namespace Text
{
    ///<summary> Public class. </summary>
    public class Str
    {
        /// <summary> Prototype. </summary>
        /// <param name="s"> String to reverse. </param>
        /// <returns> True if string is a palindrome, False if it’s not. </returns>

        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            s = Regex.Replace(s, "[:;,. \t\n\r]", "");
            char[] s_reversed = s.ToCharArray();
            Array.Reverse(s_reversed);

            for (int compare = 0; compare < s.Length; compare++)
            {
                if (s[compare] != s_reversed[compare])
                {
                    return (false);
                }
            }
            return (true);
        }
    }
}