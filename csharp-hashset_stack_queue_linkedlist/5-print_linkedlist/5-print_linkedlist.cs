using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        // Create a linkedlist empty
        LinkedList<int> list = new LinkedList<int>();
        //Check the case
        if (size < 0)
        {
            return list;
        }
        // ADD element to my linke list
        for(int i = 0; i < size; i++)
        {
            list.AddLast(i);
        }

        // go through my linked list  and print it
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        return list;
    }
}
