using LeetCode.Problems.Array;

namespace LeetCode.Nunit.Tests.Array
{
    public class GroupAnagramTest_49
    {
        [TestCaseSource(nameof(TestCase))]
        public void Test(string[] strs, IList<IList<string>> result)
        {
            var groups = GroupAnagrams_49.GroupAnagrams(strs);
            int i = 0;
            foreach (var group in groups)
            {
                Assert.That(groups.FirstOrDefault(x => x.Count == result[i].Count)!.ToHashSet().SetEquals(result[i].ToHashSet()), Is.True);
            }
        }

        public static IEnumerable<object[]> TestCase
        {
            get
            {
                return new[]
                {
                         new object[]
                            {
                                new []{"eat","tea","tan","ate","nat","bat"},
                                new List<IList<string>>
                                {
                                    new List<string> { "bat"},
                                    new List<string> { "nat","tan"},
                                    new List<string> { "ate","eat","tea"},
                                }
                            },
                           new object[]
                            {
                                new []{"","",""},
                                new List<IList<string>>
                                {
                                    new List<string> { "","",""},
                                }
                            },
                            new object[]
                            {
                                new []{""},
                                new List<IList<string>>
                                {
                                    new List<string> {""},
                                }
                            },
                        };
            }
        }
    }
}