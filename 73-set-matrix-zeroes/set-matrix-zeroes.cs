public class Solution {
  public void SetZeroes(int[][] matrix)
  {
      HashSet<int> setRow = new HashSet<int>();
      HashSet<int> setCol = new HashSet<int>();

      for (int r = 0; r < matrix.Length; r++)
          for (int c = 0; c < matrix[r].Length; c++)
          {
              if (matrix[r][c] == 0)
              {
                  setRow.Add(r);
                  setCol.Add(c);
              }
          }


      for (int r = 0; r < matrix.Length; r++)
          for (int c = 0; c < matrix[r].Length; c++)
          {
              if ((setRow.Contains(r) || setCol.Contains(c)) && matrix[r][c] != 0)
                  matrix[r][c] = 0; 
          }


    }
}

