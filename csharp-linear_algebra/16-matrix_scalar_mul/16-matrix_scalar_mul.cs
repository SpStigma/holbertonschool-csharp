using System;


/// <summary>
/// Represent the MatrixMath class.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method to multiply a matrix by a scalar.
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if(matrix.GetLength(0) != 3 && matrix.GetLength(0) != 2)
        {
            return new double[,] {{-1}};
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows < 1 || cols < 1 || rows > 3 || cols > 3)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, cols];

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        return result;
    }
}
