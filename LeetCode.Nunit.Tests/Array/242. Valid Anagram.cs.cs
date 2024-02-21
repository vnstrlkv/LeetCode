using LeetCode.Problems.Array;

namespace LeetCode.Nunit.Tests
{
    public class ValidAnagramTest_242
    {
        [TestCaseSource(nameof(TestCase))]
        public void Test(string s, string t, bool result)
        {
            var isAnagram = ValidAnagram_242.IsAnagram(s, t);
            Assert.That(isAnagram, Is.EqualTo(result));
        }

        public static IEnumerable<object[]> TestCase
        {
            get
            {
                return new[]
                {
                    new object[] {"cat","tac", true },
                    new object[] {"cat","bac", false },
                    new object[] {"anagram","bac", false },
                    new object[] {"anagram","banana", false },
                    new object[] { "eleven plus two", "twelve plus one", true },
                };
            }
        }
    }
}