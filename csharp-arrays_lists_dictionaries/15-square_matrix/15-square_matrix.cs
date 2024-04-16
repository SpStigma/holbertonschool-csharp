using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        // Get the lenght of row and cols
        int rows = myMatrix.GetLength(0);
        int cols = myMatrix.GetLength(1);
        
        // initialise a new matrix
        int[,] squaredMatrix = new int[rows, cols];
        
        // go through lines
        for (int i = 0; i < rows; i++)
        {
            // go through rows
            for (int j = 0; j < cols; j++)
            {
                // Squared calcul here
                squaredMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }
        // return the new matrix
        return squaredMatrix;        
    }
}
