using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This is the class object.</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int shearX = 0, shearY = 0;

        if (direction == 'x') { shearY = 1; }
        else if (direction == 'y') { shearX = 1; }
        else { return new double[,]{{-1}}; }

        double[,] shareMatrix = new double[,] {
            {1, shearX * factor},
            {shearY * factor, 1}
        };

        if (matrix is double[,] && matrix.GetLength(1) == 2 && matrix.GetLength(0) == 2) // Square Matrix  2X2.
        {
            int rowMat1 = matrix.GetLength(0); // Elements of vector == Rows
            int colMat1 = matrix.GetLength(1); // Vectors / Columns
            int colMat2 = shareMatrix.GetLength(1); // Vectors / Columns
            int rowMat2 = shareMatrix.GetLength(0); // Elements of vector == Rows

            double[,] mulMatrix = new double[rowMat1, colMat2];

            for (int col = 0; col < colMat1; col++)
            {
                for (int row = 0; row < rowMat1; row++)
                {
                    for (int rxc = 0; rxc < colMat2; rxc++)
                    {
                        mulMatrix[row, rxc] += matrix[row, col] * shareMatrix[col, rxc];
                    }
                }
            }
            return mulMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}
