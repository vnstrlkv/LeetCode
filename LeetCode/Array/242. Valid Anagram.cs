namespace LeetCode.Problems.Array
{
    public class ValidAnagram_242
    {
        /// <summary>
        /// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        /// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var sDict = new Dictionary<char, int>(26);
            for (int i = 0; i < s.Length; i++)
            {
                if (sDict.TryGetValue(s[i], out _))
                {
                    sDict[s[i]]++;
                }
                else
                {
                    sDict.Add(s[i], 1);
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (sDict.TryGetValue(t[i], out _))
                {
                    sDict[t[i]]--;
                    if (sDict[t[i]] < 0)
                        return false;
                }
                else return false;
            }

            return true;
        }
    }
}