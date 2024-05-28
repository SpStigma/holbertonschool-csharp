using System;

/// <summary>
/// Represent the MatrixMath.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method to brute calculate the determinant on a 2X2 and 3X3.
    /// </summary>
    public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        if (rows != 2 && rows != 3)
        {
            return -1;
        }
        if (rows != cols)
        {
            return -1;
        }

        if (rows == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        if (rows == 3)
        {
            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }
        return -1;
    }
}
