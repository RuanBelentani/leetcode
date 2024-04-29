public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (dic.ContainsKey(complement))
                return new int[]{ dic[complement], i};
            
            if (!dic.ContainsKey(nums[i]))
                dic.Add(nums[i], i);                        
        }

        throw new ArgumentException("Not found.");
    }
}