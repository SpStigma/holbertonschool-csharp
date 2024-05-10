using System;

namespace MyMath
{
    /// <summary>
    /// Represent the matrix class.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Represent the method to divide all the matrix and return a new matrix.
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            try
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                int[,] newMatrix = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        newMatrix[i, j] = matrix[i, j] / num;
                    }
                }

                return newMatrix;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
    }
}
