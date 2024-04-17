using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int size = 0;
        foreach (var item in myLList)
        {
            size += 1;
        }
        return size;
    }
}
