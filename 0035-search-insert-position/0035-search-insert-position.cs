public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int lastPosition = nums.Length -1;
        int firstPosition = 0;
        if (target > nums[lastPosition])
            return lastPosition + 1;
        
        if (target <= nums[firstPosition])
            return 0;

        while (firstPosition < lastPosition)
        {
            int middlePosition = (firstPosition + lastPosition) / 2;

            if (target == nums[middlePosition])
                return middlePosition;
            
            if (target > nums[middlePosition])  
                firstPosition = middlePosition + 1;
            else
                lastPosition = middlePosition;
        }
        return firstPosition;
    }
}