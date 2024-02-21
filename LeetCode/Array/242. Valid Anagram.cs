namespace LeetCode.Problems.Array
{
    public class ValidAnagram_242
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var sDict = new Dictionary<char, int>();
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