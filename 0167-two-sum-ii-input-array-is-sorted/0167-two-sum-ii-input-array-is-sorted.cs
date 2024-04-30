public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for(int i = 0; i < numbers.Length; i++)
        {
            int complement = target - numbers[i];

            if (dic.ContainsKey(complement))
                return new int[]{ dic[complement]+1, i+1};
            
            if (!dic.ContainsKey(numbers[i]))
                dic.Add(numbers[i], i);                        
        }

        throw new ArgumentException("Not found.");
    }
}