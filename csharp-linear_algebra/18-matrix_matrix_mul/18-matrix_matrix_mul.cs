using System;

/// <summary>
/// Represent the MatrixMath class.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method to multiply 2 matrix.
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rowsMatrix1 = matrix1.GetLength(0);
        int colsMatrix1 = matrix1.GetLength(1);
        int rowsMatrix2 = matrix2.GetLength(0);
        int colsMatrix2 = matrix2.GetLength(1);

        if (colsMatrix1 != rowsMatrix2)
        {
            return new double[,] {{-1}};
        }

        double[,] result = new double[rowsMatrix1, colsMatrix2];

        // Go through rows Matrix1
        for (int i = 0; i < rowsMatrix1; i++)
        {
            // Go through cols Matrix2
            for(int j = 0; j < colsMatrix2; j++)
            {
                double sum = 0;
                //go through col Matrix1
                for (int k = 0; k < colsMatrix1; k++)
                {
                    // sum of number of position i, k multiplie by the position of matrix2 k, j.
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }
}

