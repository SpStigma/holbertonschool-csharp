using System;
using System.Collections.Generic;


namespace MyMath
{
    /// <summary>
    /// Represent the Operation class.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Represent the method to return the greater number in a list.
        /// </summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }

            int max = nums[0];

            foreach(int num in nums)
            {
                int numbersGreater = 0;
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
