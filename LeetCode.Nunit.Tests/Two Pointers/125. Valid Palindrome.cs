using LeetCode.Problems.Two_Pointers;

namespace LeetCode.Nunit.Tests.TwoPointers
{
    public class ValidPalindromeTest_125
    {
        [TestCaseSource(nameof(TestCase))]
        public void Test(string str, bool target)
        {
            var result = ValidPalindrome_125.IsPalindrome(str);
            Assert.That(result, Is.EqualTo(target));
        }

        public static IEnumerable<object[]> TestCase
        {
            get
            {
                return new[]
                {
                    new object[] { "A man, a plan, a canal: Panama", true },
                    new object[] {"cat tac", true },
                    new object[] {"cat 2tac", false },
                    new object[] {"", true },
                };
            }
        }
    }
}