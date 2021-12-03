using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int row = myMatrix.GetLength(0); //fila
		int column = myMatrix.GetLength(1); //columna
		int[,] new_Matrix = new int[row, column]; // nueva matriz

		for (int i = 0; i < row; i++)
		{
			for (int j = 0; j < column; j++)
			{
				new_Matrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
			}
		}
		return (new_Matrix);
    }
}
