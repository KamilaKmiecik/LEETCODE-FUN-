public class Solution {
    public string LongestCommonPrefix(string[] strs) {
       //first word 
        string pref = strs[0];

        int l = strs.Length;
        for (int i = 1; i < l; i++) {
            //checking each word in a for loop
            //keep checking longer and longer prefixes while they still match
            while (!strs[i].StartsWith(pref)) {
                pref = pref.Substring(0, pref.Length - 1);
            }

            //exit when there isn't a matching sequence
        }

        return pref;
    }
}