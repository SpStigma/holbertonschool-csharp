using System;

class Program
{
    public static void Main()
    {
        // Create a 2D array empty of 5 * 5
        int[,] array2D = new int[5, 5];

        // initialise the case 2, 2 at 1
        array2D[2, 2] = 1;

        //go through line
        for(int i = 0; i < array2D.GetLength(0); i++)
        {
            //  go through columns
            for(int j = 0; j < array2D.GetLength(1); j++)
            {
                // check if the las element of the line
                if (j < array2D.GetLength(1) - 1)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                else
                {
                    Console.Write(array2D[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}