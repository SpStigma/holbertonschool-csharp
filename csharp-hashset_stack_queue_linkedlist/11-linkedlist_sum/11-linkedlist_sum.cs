using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0; 
        foreach (var value in myLList)
        {
            sum += value;
        }
        return sum;
    }
}
