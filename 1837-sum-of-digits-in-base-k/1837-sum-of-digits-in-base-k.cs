public class Solution {
    public int SumBase(int n, int k) {
        List<int> digits = new List<int>();

        while (n > 0)
        {
            digits.Add(n % k);
            n = n / k;
        }

        int sumOfDigits = 0;
        foreach (int digit in digits)
        {
            sumOfDigits += digit;
        }

        return sumOfDigits;
    }
}