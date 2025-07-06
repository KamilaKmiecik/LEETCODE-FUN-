public class Solution {
    public int StrStr(string haystack, string needle) {
     
            if (!haystack.Contains(needle))
                return -1;

            for (int i = 0; i < haystack.Length; i++)
            {
                var c = haystack[i];
                if (c.Equals(needle[0]))
                    if(haystack.Substring(i, needle.Length).Equals(needle))
                        return i;
            }

            return -1;  
    }
}