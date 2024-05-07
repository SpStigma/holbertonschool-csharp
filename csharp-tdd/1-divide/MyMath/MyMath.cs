using System;


namespace MyMath
{
    ///<summary>Represent Matrix class.</summary>
    public class Matrix
    {
        ///<summary>Method to divide a matrix and return to a new matrix.</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            try
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                int[;] result = new int[rows, cols];
                for(int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < cols; j++)
                    {
                        result[i, j] = matrix[i, j] / num;
                    }
                }
                
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
