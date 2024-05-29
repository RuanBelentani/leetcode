public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
        int maxLength = 0;
        int start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (charIndexMap.ContainsKey(s[i]))
            {
                start = Math.Max(charIndexMap[s[i]] + 1, start);
            }

            charIndexMap[s[i]] = i; //Add if this Key does not exist, if it does, update the Value.
            //charIndexMap.Add(s[i], i); //Only add if the Key is not already present, if it is, throw an exception.

            maxLength = Math.Max(maxLength, i - start + 1);
        }

        return maxLength;
    }
}