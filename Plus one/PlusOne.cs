public class Solution {
    public int[] PlusOne(int[] digits) {
        var length = digits.Length;
        for(var i = length - 1; i >= 0; i--)
        {
            if(digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        
        var newDigits = new int[length + 1];
        newDigits[0] = 1;
        return newDigits;
    }
}