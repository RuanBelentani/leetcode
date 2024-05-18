public class Solution {
    public int[] TwoSum(int[] nums, int target) {    
        for (var i = 0; i < nums.Length -1; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j] == target) && (i != j))
                    return new int[]{i, j};
            }
        }
        return new int[]{0};
        //throw new ArgumentException("Not found.");
    }
} 
//9+8+7+6+5+4+3+2+1
//Sum = (First Element + Last Element) * n / 2