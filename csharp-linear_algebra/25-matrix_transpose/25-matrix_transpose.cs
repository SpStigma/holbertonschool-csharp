using System;

/// <summary>
/// Represent the Matrix class.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Methode to transpose a matrix and return it.
    /// </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows == 0 && cols == 0)
        {
            return new double[,] {{}};
        }

        double[,] result = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        return result;
    }
}
