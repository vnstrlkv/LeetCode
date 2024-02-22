using LeetCode.Problems.Array;

namespace LeetCode.Nunit.Tests.Array
{
    public class ContainsDuplicateTest_217
    {
        [TestCaseSource(nameof(TestCase))]
        public void Test(int[] nums, bool result)
        {
            var containsDublicate = ContainsDuplicate_217.ContainsDuplicate(nums);
            Assert.That(containsDublicate, Is.EqualTo(result));
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
                    new object[] {new[]{ 2, 14, 18, 22, 22 }, true },
                    new object[] {new[]{ 2, 2, 18, 1, 22 }, true },
                    new object[] {new[]{ 2, 2 }, true },
                    new object[] {new[] { 0, 4, 5, 0, 3, 6 }, true },
                };
            }
        }
    }
}