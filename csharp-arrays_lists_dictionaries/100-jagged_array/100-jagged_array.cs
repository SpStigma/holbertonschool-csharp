using System;

class Program
{
    public static void Main()
    {
        int[][] jaggedArrays = new int[3][];

        jaggedArrays[0] = new int[] {0, 1 , 2, 3};
        jaggedArrays[1] = new int[] {0, 1, 2, 3, 4, 5, 6};
        jaggedArrays[2] = new int[] {0, 1};

        for (int i = 0; i < jaggedArrays.Length; i++)
        {
            for (int j = 0; j < jaggedArrays[i].Length; j++)
            {
                Console.Write($"{jaggedArrays[i][j]}");
                if (j == jaggedArrays[i].Length - 1)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
