using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int nodePosition = 0;
        foreach(var item in myLList)
        {
            if (item == value)
            {
                return nodePosition;
            }
            nodePosition++;
        }
        return -1;
    }
}
