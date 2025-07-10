public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        //treating the 2D matrrix as a sorted 1D matrix with m*n length
        int m = matrix.Length, n = matrix[0].Length;
        int start = 0, end = m*n-1; 

        while(start <= end)
        {
            int middle_index = start + (end - start) / 2;
            //column is just 
            // 1  2  3  4  5
            // 6  7  8  9 10  
            // 11 12 13 14 15   
            // mid = 0 + (14 - 0)/2 = 7  - 
            int middle = matrix[middle_index /n][middle_index % n];
            if(target == middle)
                return true; 

            if(target <= middle)
                end = middle_index -1;
            else start = middle_index +1;
        }

        return false; 
    
    }
}