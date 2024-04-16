using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int maxScore = 0;
        string bestStudents = "";

        foreach(var kvp in myList)
        {
            if(kvp.Value > maxScore)
            {
                maxScore = kvp.Value;
                bestStudents = kvp.Key;
            }
        }
        return bestStudents;
    }
}