using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorhtm_Example
{
    internal class Solution
    {
        public int[] GetConcatenation(int[] nums)
        {
            if (nums.Length > 1000 || nums.Length < 1)
            {
                throw new ArgumentOutOfRangeException("array needs to be between 1 and 1000 length");
            }

            var answer = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                answer[i] = nums[i];
                answer[i + nums.Length] = nums[i];
            }

            return answer;
        }
    }
}
