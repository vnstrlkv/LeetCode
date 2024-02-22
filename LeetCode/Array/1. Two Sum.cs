namespace LeetCode.Problems.Array
{
    public class TwoSum_1
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            int firstIndex = -1;
            int secondIndex = -1;
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(target - nums[i]))
                {
                    firstIndex = result[target - nums[i]];
                    secondIndex = i;
                    break;
                }
                result[nums[i]] = i;
            }

            return new int[] { firstIndex, secondIndex };
        }
    }
}