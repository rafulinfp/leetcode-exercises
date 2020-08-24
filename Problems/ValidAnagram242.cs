using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblems.Problems
{
    public class ValidAnagram242
    {

        // Given two strings s and t , write a function to determine if t is an anagram of s.

        // Example 1:

        // Input: s = "anagram", t = "nagaram"
        // Output: true
        // Example 2:

        // Input: s = "rat", t = "car"
        // Output: false
        // Note:
        // You may assume the string contains only lowercase alphabets.

        // Follow up:
        // What if the inputs contain unicode characters? How would you adapt your solution to such case?
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            // keep track of all ocurrences for t
            var dict = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c]++;
                }
            }

            // substract them out of the dict 
            foreach (char c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    dict[c]--;
                }
            }

            // all values should be 0
            return dict.Values.All(s => s == 0);
        }
    }
}