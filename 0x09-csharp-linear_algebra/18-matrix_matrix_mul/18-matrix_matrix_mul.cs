using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This is the class object.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (
            (!(matrix1 is double[,]) || !(matrix2 is double[,])) ||
            (matrix2.GetLength(0) != matrix1.GetLength(1))
        )
        {
            return new double[,]{{-1}};
        }

        int i, j, k;
        int matrix1_len_1 = matrix1.GetLength(0);
        int matrix1_len_2 = matrix1.GetLength(1);
        int matrix2_len_1 = matrix2.GetLength(0);
        int matrix2_len_2 = matrix2.GetLength(1);
        double[,] mul_matrix = new double[matrix1_len_1, matrix2_len_2];

        for (i = 0 ; i < matrix1_len_2 ; i++)
        {
            for (j = 0 ; j < matrix1_len_1 ; j++)
            {
                for (k = 0 ; k < matrix2_len_2 ; k++)
                {
                    mul_matrix[j, k] += matrix1[j, i] * matrix2[i, k];
                }
            }
        }

        return(mul_matrix);
    }
}
