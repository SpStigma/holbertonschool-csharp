using System;

/// <summary>
/// Represent the MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Represent a Matrix Shear Method.
    /// </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (direction != 'x' && direction != 'y')
        {
            return new double[,] {{-1}};
        }

        if (matrix.GetLength(0) != 2)
        {
            return new double[,] {{-1}};
        }

        double[,] result = new double[2, 2];
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (direction == 'x')
        {
            for (int i = 0; i < rows; i++)
            {
                result[i, 0] = matrix[i, 0] + factor * matrix[i, 1];
                result[i, 1] = matrix[i , 1];
            }
        }
        else if (direction == 'y')
        {
            for (int i = 0; i < rows; i++)
            {
                result[i, 0] = matrix[i, 0];
                result[i , 1] = factor * matrix[i, 0] + matrix[i, 1];
            }
        }

        return result;
    }
}