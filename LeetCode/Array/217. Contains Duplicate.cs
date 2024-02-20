namespace LeetCode.Problems.Array
{
    public class ContainsDuplicate_217
    {
        /// <summary>
        /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length < 2)
                return false;
            var hashset = new HashSet<int>();
            hashset.Add(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                if (hashset.Contains(nums[i]))
                    return true;
                hashset.Add(nums[i]);
            }
            return false;
        }
    }
}