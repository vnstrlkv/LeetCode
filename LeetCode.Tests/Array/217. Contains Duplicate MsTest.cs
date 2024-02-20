using LeetCode.Problems.Array;

namespace LeetCode.MSTest.Tests.Array
{
    [TestClass]
    public class ContainsDuplicateTest_217
    {
        [TestMethod]
        [DynamicData(nameof(TestCase))]
        public void Test(int[] nums, bool result)
        {
            var containsDuplicate = ContainsDuplicate_217.ContainsDuplicate(nums);
            Assert.AreEqual(result, containsDuplicate);
        }

        public static IEnumerable<object[]> TestCase
        {
            get
            {
                return new[]
                {
                    new object[] {new[]{1, 2, 3, 1 }, true },
                    new object[] {new[]{1, 2, 3, 4 }, false },
                    new object[] {new[]{ 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true },
                    new object[] {new[]{ 1, 5, 4, 3, 2, 4, 3, 2, 4, 2 }, true },
                    new object[] {new[]{ 2, 14, 18, 22, 22 } },
                    new object[] {new[]{ 2, 2, 18, 1, 22 }, true }
                };
            }
        }
    }
}