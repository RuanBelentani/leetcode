public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] result = new int[nums.Length];
        int firstPosition = 0;
        int lastPosition = nums.Length -1;
        
        for(var i = lastPosition; i >= 0; i--)
        {
            int lastPositionSquare = nums[lastPosition] * nums[lastPosition];
            int firstPositionSquare = nums[firstPosition] * nums[firstPosition];

            if (lastPositionSquare > firstPositionSquare)
            {
                result[i] = lastPositionSquare;
                lastPosition--;
            }
            else
            {
                result[i] = firstPositionSquare;
                firstPosition++;
            }
        }

        return result;
    }
}