public class Solution {
    public IList<int> LastVisitedIntegers(int[] nums) {
        int[] seen = new int[nums.Length];
        List<int> ans = new List<int>();
        int aux;
        int lastNumber = 0, seenCount = 0, k = 0;    

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                int reservedNumber = nums[i];
                for (var j = 0; j < seen.Length; j++)
                {
                    aux = reservedNumber;
                    reservedNumber = seen[j];
                    seen[j] = aux;
                }
                seenCount++;
            }
            else
            {
                if (lastNumber == -1)
                    k++;
                else
                    k = 1;
               
                if (k > seenCount)
                    ans.Add(-1);
                else
                    ans.Add(seen[k-1]);
            }
            lastNumber = nums[i];
        }
        return ans;
    }
}