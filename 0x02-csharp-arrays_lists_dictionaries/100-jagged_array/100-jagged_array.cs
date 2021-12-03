using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[][] jagged_array =  new int[3][];
            jagged_array[0] = new int[] { 0, 1, 2, 3 };
            jagged_array[1] = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            jagged_array[2] = new int[] { 0, 1 };

            for (int i = 0; i < jagged_array.GetLength(0); i++)
            {
                var join = string.Join(" ", jagged_array[i]);
                Console.WriteLine(join);
            }
        }
    }
}
