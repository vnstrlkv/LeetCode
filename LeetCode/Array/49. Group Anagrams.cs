using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Array
{
    public class GroupAnagrams_49
    {
        /// <summary>
        /// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
        /// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var strsList = strs.ToList();
            var orderedStrs = new List<string>();
            var answer = new List<IList<string>>();
            foreach (var str in strs)
            {
                orderedStrs.Add(string.Concat(str.OrderBy(c => c)));
            }

            while (orderedStrs.Count > 0)
            {
                int i = 0;
                var anagramsList = new List<string>();
                if (orderedStrs.Count == 1)
                {
                    anagramsList.Add(strsList[i]);
                    orderedStrs.RemoveAt(i);
                    strsList.RemoveAt(i);
                    answer.Add(anagramsList);
                    break;
                }
                anagramsList.Add(strsList[i]);
                for (int j = 1; j < orderedStrs.Count; j++)
                {
                    if (orderedStrs[i] == orderedStrs[j])
                    {
                        anagramsList.Add(strsList[j]);
                        orderedStrs.RemoveAt(j);
                        strsList.RemoveAt(j);
                        j--;
                    }
                }
                orderedStrs.RemoveAt(i);
                strsList.RemoveAt(i);
                if (anagramsList.Count > 0)
                {
                    answer.Add(anagramsList);
                }
            }
            return answer;
        }
    }
}