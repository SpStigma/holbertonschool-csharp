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
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        if (rows != 2 || cols != 2)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, cols];

        if (angle >= 0)
        {
            result[0, 0] = cos * matrix[0, 0] - sin * matrix[0, 1];
            result[0, 1] = sin * matrix[0, 0] + cos * matrix[0, 1];
            result[1, 0] = cos * matrix[1, 0] - sin * matrix[1, 1];
            result[1, 1] = sin * matrix[1, 0] + cos * matrix[1, 1];
        }
        else
        {
            result[0, 0] = cos * matrix[0, 0] + sin * matrix[0, 1];
            result[0, 1] = -sin * matrix[0, 0] + cos * matrix[0, 1];
            result[1, 0] = cos * matrix[1, 0] + sin * matrix[1, 1];
            result[1, 1] = -sin * matrix[1, 0] + cos * matrix[1, 1];
        }

        return result;
    }
}

