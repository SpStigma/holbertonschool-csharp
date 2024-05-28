using System;

/// <summary>
/// Represent the MatrixMath class.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that apply a Matrix Rotation.
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if ((matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2))
        {
            return new double[,] { { -1 } };
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);


        double[,] Radians = {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = 0; k < cols; k++)
                {
                    result[i, j] += Math.Round(matrix[i, k] * Radians[k, j], 2);
                }
            }
        }
        return result;
    }
}


