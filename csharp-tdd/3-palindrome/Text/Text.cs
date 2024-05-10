using System;
using System.Text.RegularExpressions;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            string cleanedString = Regex.Replace(s.ToLower(), @"[^a-z0-9]", "");

            if (cleanedString == "")
            {
                return true;
            }

            int i = 0;
            int j = cleanedString.Length - 1;

            while (i < j)
            {
                if (cleanedString[i] != cleanedString[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }
    }
}
