using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> odd = new List<bool>();
        foreach (int nums in myList)
        {
            if (nums % 2 == 0)
            {
                odd.Add(true);
            }
            else
            {
                odd.Add(false);
            }
        }
        return odd;
    }
}
