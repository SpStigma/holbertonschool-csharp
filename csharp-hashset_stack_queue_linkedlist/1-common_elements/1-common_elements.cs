using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> commonElements = new List<int>();
        
        // Create HashSet for fast lookup
        HashSet<int> set1 = new HashSet<int>(list1);
        
        // Iterate through list2, add common elements to commonElements list
        foreach (int num in list2)
        {
            if (set1.Contains(num))
            {
                commonElements.Add(num);
                // Remove from set1 to avoid duplicates
                set1.Remove(num);
            }
        }
        
        // Sort the common elements list
        commonElements.Sort();
        
        return commonElements;
    }
}
