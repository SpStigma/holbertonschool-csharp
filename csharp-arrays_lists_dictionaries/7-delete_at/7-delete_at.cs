using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (myList != null && index < myList.Count && index >= 0)
        {
            myList.Remove(myList[index]);
        }
        else
        {
            Console.WriteLine("Index is out of range");
        }
        return myList;
    }
}