public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 2) return n; 

        // j = 1, k = 2, result = 0
        // result = 1+ 2 = 3, j = 2, k = 3;
        // result = 2 + 3 =5, j = 3, k = 5; 
        int j = 1, k =2, result = 0; 
        for(int i = 3; i <=n; i++)
        {
            result = j + k; 
            j = k;
            k = result;
        }

        return result;

    }
}