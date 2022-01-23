using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This is the class object.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (
            (matrix.GetLength(0) != matrix.GetLength(1)) ||
            (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3) ||
            (matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
        )
        {
            return new double[,]{{-1}};
        }

        int i, j;
        int matrix_len = matrix.GetLength(0);
        double[,] sca_matrix = new double[matrix_len, matrix_len];

        for (i = 0 ; i < matrix_len ; i++)
        {
            for (j = 0 ; j < matrix_len ; j++)
            {
                sca_matrix[i, j] = (matrix[i, j] * scalar);
            }
        }

        return(sca_matrix);
    }
}
