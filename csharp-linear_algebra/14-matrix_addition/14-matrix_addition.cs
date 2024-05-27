using System;

/// <summary>
/// represent the MatrixMath class.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method to add 2 matrix of the same size between 2d or 3d.
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if ((matrix1.GetLength(0) != 3 && matrix1.GetLength(0) != 2) ||
            (matrix2.GetLength(0) != 3 && matrix2.GetLength(0) != 2) ||
            (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1)))
        {
            return new double[,] {{-1}};
        }

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        double [,] result = new double[rows,cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j =0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }
}
