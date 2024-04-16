﻿/*using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if(index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        List<int> deletedList = new List<int>();

        for(int i = 0; i < myList.Count; i++)
        {
            if (i != index)
            {
                deletedList.Add(myList[i]);
            }
        }
        return deletedList;
    }
}
*/
using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (myList == null || index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        myList.RemoveAt(index);
        return myList;
    }
}