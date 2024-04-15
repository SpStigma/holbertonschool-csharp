using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> newList = new List<int>();
        for (int element = 0; element < size; element++)
        {
            newList.Add(element);
            Console.Write(element);
            
            if (element < size - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        return newList;
    }
}