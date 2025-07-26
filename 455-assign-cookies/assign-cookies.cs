public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(s);
        Array.Sort(g);
        
        int contentChildren = 0, childIdx = 0, cookieIdx = 0;
        
        while (childIdx < g.Length && cookieIdx < s.Length) {
            if (s[cookieIdx] >= g[childIdx]) {
                contentChildren++;
                childIdx++;
            }
            cookieIdx++;
        }
        
        return contentChildren;
    }
}