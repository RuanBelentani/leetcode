public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

        foreach(var letter in s)
        {
            if (frequencyMap.ContainsKey(letter))
                frequencyMap[letter]++;
            else
                frequencyMap.Add(letter, 1);
        }

        StringBuilder result = new StringBuilder();
        foreach(var charac in frequencyMap.OrderByDescending(s => s.Value))
        {
            result.Append(charac.Key, charac.Value);
        }

        return result.ToString();
    }
}