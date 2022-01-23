using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This is the class object.</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double cosinangle = Math.Cos(angle);
        double sinangle = Math.Sin(angle);

        double[,] rotateMatrix = new double[,] {
            {cosinangle, sinangle},
            {-sinangle, cosinangle}
        };

        if (matrix is double[,] && matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            int rowMat1 = matrix.GetLength(0); // Elements of vector == Rows
            int colMat1 = matrix.GetLength(1); // Vectors / Columns
            int colMat2 = rotateMatrix.GetLength(1); // Vectors / Columns
            int rowMat2 = rotateMatrix.GetLength(0); // Elements of vector == Rows

            double[,] mulMatrix = new double[rowMat1, colMat2];

            for (int col = 0; col < colMat1; col++)
            {
                for (int row = 0; row < rowMat1; row++)
                {
                    for (int rxc = 0; rxc < colMat2; rxc++)
                    {
                        mulMatrix[row, rxc] = Math.Round(mulMatrix[row, rxc] + matrix[row, col] * rotateMatrix[col, rxc], 2);
                    }
                }
            }
            return mulMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}
