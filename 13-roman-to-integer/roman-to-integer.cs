public class Solution {
 public int RomanToInt(string s)
 {

     var dict = new Dictionary<char, int> {
    {'I', 1},
    {'V', 5},
    {'X', 10},
    {'L', 50},
    {'C', 100},
    {'D', 500},
    {'M', 1000},
    };

     int i = 0;
     for (int j = 0; j < s.Length ; j++)
    {
            int currRoman = dict[s[j]];
            int nextRoman = (j + 1 < s.Length) ? dict[s[j + 1]] : 0;

            if (currRoman < nextRoman)
                i -= currRoman;
            else
                i += currRoman;
        }

     return i;
 }
}