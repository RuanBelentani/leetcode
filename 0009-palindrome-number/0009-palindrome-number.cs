public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;
        
        string number = Convert.ToString(x);    
        
        for(int i = 0, j = number.Length -1; i < number.Length / 2; i++,j--)
        {
            if (number[i] != number[j])
                return false;
        }        
        return true;        
    }
}