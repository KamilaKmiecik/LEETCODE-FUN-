public class Solution {
    public int LengthOfLastWord(string s) {
      if (string.IsNullOrWhiteSpace(s))
     return 0;

        if (!s.Contains(" "))
            return s.Length;

        var split = s.Split(' ');

        foreach (string str in split.Reverse())
        {
            if(str.Length != 0)
                    return str.Length;

        }

        return 0; 
    }
}