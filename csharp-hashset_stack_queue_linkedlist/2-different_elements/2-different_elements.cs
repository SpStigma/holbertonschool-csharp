using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> differentElements = new List<int>();
        
        // Create HashSet
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        
        // Iterate through list1, add elements not in list2 to differentElements
        foreach (int num in list1)
        {
            if (!set2.Contains(num))
            {
                differentElements.Add(num);
            }
        }
        
        // Iterate through list2, add elements not in list1 to differentElements
        foreach (int num in list2)
        {
            if (!set1.Contains(num))
            {
                differentElements.Add(num);
            }
        }
        
        differentElements.Sort();
        
        return differentElements;
    }
}