public class Solution {
    public bool IsPalindrome(string s) {
        
        //s = s.Where(x => char.IsLetterOrDigit(x)).ToString().ToLower();
        //return s.Equals(s.Reverse());

        if(string.IsNullOrWhiteSpace(s))
            return true; 

        s = new string(s.Where(x => char.IsLetterOrDigit(x)).ToArray()).ToLower();
        int i = 0, l = s.Length -1; 
        
        while(i < l)
        {
            if(s[i] != s[l])
                return false;

                i++; l--; 
        }

        return true; 
    }
}