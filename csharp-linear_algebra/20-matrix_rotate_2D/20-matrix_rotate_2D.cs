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
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2)
        {
            return new double[,] { { -1 } };
        }

        double[,] RadiansNegative = {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        double[,] RadiansPositive = {{Math.Cos(angle), -1 * Math.Sin(angle)}, {Math.Sin(angle), Math.Cos(angle)}};
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = 0; k < cols; k++)
                {
                    if (angle >= 0)
                    {
                        result[i, j] += Math.Round(matrix[i, k] * RadiansPositive[k, j], 2);
                    }
                    else
                    {
                        result[i, j] += Math.Round(matrix[i, k] * RadiansNegative[k, j], 2);
                    }
                }
            }
        }

        return result;
    }
}


