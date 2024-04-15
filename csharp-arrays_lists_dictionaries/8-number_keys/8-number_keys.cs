using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int iteration = 0;
        foreach (KeyValuePair<string, string> kvp in myDict)
        {
            iteration++;
        }
        return iteration;
    }
}
