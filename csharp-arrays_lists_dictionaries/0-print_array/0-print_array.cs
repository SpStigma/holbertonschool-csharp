using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
        {
            Console.WriteLine("");
        }
        int [] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = i;
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(' ');
            }
            if (i == array.Length - 1)
            {
                Console.WriteLine();
            }
        }
        return array;
    }
}