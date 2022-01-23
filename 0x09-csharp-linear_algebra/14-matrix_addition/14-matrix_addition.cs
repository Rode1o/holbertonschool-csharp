using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This is the class object.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int i, j;

        if (
            (matrix1.GetLength(0) != matrix1.GetLength(1)) ||
            (matrix2.GetLength(0) != matrix2.GetLength(1)) ||
            (matrix1.GetLength(0) != matrix2.GetLength(0)) ||
            (matrix1.GetLength(1) != matrix2.GetLength(1))
        )
        {
            return new double[,]{{-1}};
        }

        int matrix1_len = matrix1.GetLength(0);

        for (i = 0 ; i < matrix1_len ; i++)
        {
            for (j = 0 ; j < matrix1_len ; j++)
            {
                matrix1[i, j] += matrix2[i, j];
            }
        }

        return(matrix1);
    }
}
