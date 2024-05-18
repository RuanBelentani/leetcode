public class Solution {
    public int[] TwoSum(int[] nums, int target) {    
        Dictionary<int, int> number = new Dictionary<int, int>();                                            
        for (var i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            
            if ((number.ContainsKey(difference)) && 
                (number[difference] != i))
                return new int[]{number[difference], i};
            else if (!number.ContainsKey(nums[i]))             
                number.Add(nums[i], i);
        }
        
        return new int[]{1};        
    }
} 
//9+8+7+6+5+4+3+2+1
//Sum = (First Element + Last Element) * n / 2