using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Represent the Str class.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Represent the method which return the index of a unique character in a sentence.
        /// </summary>
        public static int UniqueChar(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
