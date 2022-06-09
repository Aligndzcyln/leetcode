public class Solution {
    public int LengthOfLastWord(string s) {
        var length = 0;
        s = s.Trim();
        
        for(var i = s.Length - 1; i >= 0; i--)
        {
            if(s[i] == ' ')
            {
                return length;
            }
            
            length++;
        }
        return length;
    }
}