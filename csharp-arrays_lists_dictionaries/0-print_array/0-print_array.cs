using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if(size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        if(size == 0)
        {
            Console.WriteLine("");
        }

        int[] result = new int[size];
        for(int i = 0; i < size; i++)
        {
            result[i] = i;
            Console.Write(result[i]);
            if (i < result.Length - 1)
            {
                Console.Write(' ');
            }
        }
        Console.WriteLine();
        return result;
    }
}