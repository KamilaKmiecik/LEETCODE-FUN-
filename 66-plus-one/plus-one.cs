public class Solution {
    public int[] PlusOne(int[] digits) {
                //if the last number is lower tha 9 then you can just add 1 and return
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i] += 1;
                   return digits; 
                }
                //if not 9+1 give 0, the 1 is passed to another section 0 stays at index
                digits[i] = 0;
            }

            
            digits = new int[digits.Length + 1];
            digits[0] = 1;


            return digits;    
    }
}