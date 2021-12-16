using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> Public class. </summary>
    public class Operations
    {
        /// <summary> Prototype. </summary>
        /// <param name="nums"> List of nums. </param>
        /// <returns> Max integer in list. </returns>
        public static int Max(List<int> nums)
        {
            int max = 0;

            if (nums == null || nums.Count <= 0)
            {
                return (0);
            }
            nums.Sort();

            foreach (int i in nums)
            {
                max = i;
            }
            return (max);
        }
    }
}
