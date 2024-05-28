using System;

/// <summary>
/// Represent the MatrixMath class.
/// </summary>
class MatrixMath
{
    /// <summary>
    ///Method that calculates the inverse of a 2D matrix.
    /// </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            if (det != 0)
            {
                double[,] result = {
                    {Math.Round(matrix[1, 1] / det, 2), Math.Round((-1) * matrix[0, 1] / det, 2)}, 
                    {Math.Round((-1) * matrix[1, 0] / det, 2), Math.Round(matrix[0, 0] / det, 2)}
                };
                return result;
            }
        }
        return new double[,] {{-1}};
    }
}

