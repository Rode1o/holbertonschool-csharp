using System;
using System.Text.RegularExpressions;

namespace Text
{
    ///<summary> Public class. </summary>
    public class Str
    {
        /// <summary> Prototype. </summary>
        /// <param name="s"> String. </param>
        /// <returns> Number of words in s. </returns>

        public static int CamelCase(string s)
        {
            if(s == "" || s == null)
            {
                return(0);
            }
            int count = 1;
            for(int i = 0; i < s.Length; i++)
            {
                if(char.IsUpper(s[i]) == true)
                {
                    count ++;
                }
            }
            return(count);
        }
    }
}