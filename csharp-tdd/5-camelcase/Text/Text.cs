using System;

namespace Text
{
    /// <summary>
    /// Represent the Str Class.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Represent the method to count how many word that has in a sentence via CamelCase.
        /// </summary>
        public static int CamelCase(string s)
        {
            if (s == null)
            {
                return 0;
            }

            int wordCount = 1;

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    wordCount++;
                }
            }
            return wordCount;
        }
    }
}
