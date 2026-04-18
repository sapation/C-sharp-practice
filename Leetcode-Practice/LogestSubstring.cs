namespace Leetcode_Practice
{
    public class LogestSubstring
    {
        public int LengthofLongestSubstring(string s)
        {
            int left = 0;
            int right = 0;
            int maxLength = 0;
            HashSet<char> charSet = new();

            while(right < s.Length)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    right++;
                    maxLength = Math.Max(maxLength, right - left);
                } else
                {
                    charSet.Remove(s[left]);
                    left++;
                }
            }

            return maxLength;
        }
    }
}


/**
* Sliding window questions
*string s = "abcabcbb";

LogestSubstring substring = new();

int result = substring.LengthofLongestSubstring(s);
Console.WriteLine($"Maximum Length: {result}");
*/