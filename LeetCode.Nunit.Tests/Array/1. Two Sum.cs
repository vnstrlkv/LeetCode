using LeetCode.Problems.Array;

namespace LeetCode.Nunit.Tests.Array
{
    internal class TwoSumTest_1
    {
        [TestCaseSource(nameof(TestCase))]
        public void Test(int[] nums, int target, int[] result)
        {
            var indexes = TwoSum_1.TwoSum(nums, target);
            Assert.That(indexes.Order(), Is.EqualTo(result.Order()));
        }

        public static IEnumerable<object[]> TestCase
        {
            get
            {
                return new[]
                {
                    new object[] {new[]{1, 2, 3, 1 }, 5, new[] { 1, 2 } },
                    new object[] {new[]{1, 2, 3, 1 }, 2, new[] { 0, 3 } },
                    new object[] {new[]{5, 5, 3, 1 }, 10, new[] { 0, 1 } },
                    new object[] {new[] { 0, 4, 3, 0 }, 0, new[] { 0, 3 } },
                    new object[] {new[] { -3, 4, 3, 90 }, 0, new[] { 0, 2 } },
                };
            }
        }
    }
}