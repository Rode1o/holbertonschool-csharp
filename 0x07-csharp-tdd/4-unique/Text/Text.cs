using System;
using System.Text.RegularExpressions;

namespace Text
{
    ///<summary> Public class. </summary>
    public class Str
    {
        /// <summary> Prototype. </summary>
        /// <param name="s"> String to reverse. </param>
        /// <returns> Index of first non-repeating character or -1 if there is no non-repeating character. </returns>

        public static int UniqueChar(string s)
        {
            if (s == "" || s == null)
            {
                return (-1);
            }
            s = s.ToLower();
            char[] arr = s.ToCharArray();
            int x;
            
            for (int y = 0; y <= arr.Length - 1; y++)
            {
                x = 0;
                for (int z = 0; z <= arr.Length - 1; z++)
                {
                    if (y != z)
                        if (arr[y] == arr[z])
                        {
                            x += 1;
                        }
                }
                if (x == 0)
                    return (y);
            }
            return (-1);
        }
    }
}