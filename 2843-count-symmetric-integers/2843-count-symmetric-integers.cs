public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        int result = 0;
        
        for (int i = low; i <= high; i++)
        {
            String sNumber = i.ToString();
            int qtdChars = sNumber.Length;
            
            if (qtdChars % 2 == 0)
            {
                var firstMiddle = sNumber.Substring(0, (qtdChars/2));
                var lastMiddle = sNumber.Substring((qtdChars/2), (qtdChars/2));
                    
                int firstTotal = 0;
                int lastTotal = 0;
                foreach(var numb1 in firstMiddle)
                {
                    firstTotal += Convert.ToInt32(numb1.ToString());
                }
                foreach(var numb2 in lastMiddle)
                {
                    lastTotal += Convert.ToInt32(numb2.ToString());
                }
                
                if (firstTotal == lastTotal)                    
                    result += 1;
            }            
        }
        return result;
    }
}