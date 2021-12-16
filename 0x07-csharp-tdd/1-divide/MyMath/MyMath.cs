using System;

namespace MyMath
{
    /// <summary> Public class. </summary>
    public class Matrix
    {
        /// <summary> Prototype. </summary>
        /// <param name="matrix"> Array of integers. </param>
        /// <param name="num"> Number to divide. </param>
        /// <returns> A new matrix containing divided elements. </returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }
            else if (matrix == null)
            {
                return (null);
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = matrix[i, j] / num;
                    }
                }
                return (matrix);
            }
        }
    }
}