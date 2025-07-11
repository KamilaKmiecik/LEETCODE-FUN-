public class Solution {
    public bool IsValidSudoku(char[][] board) {

        //9 element hashset for each column, row and box
        HashSet<char>[] row = new HashSet<char>[9];
        HashSet<char>[] col = new HashSet<char>[9];
        HashSet<char>[] box = new HashSet<char>[9];

        for (int i = 0; i < 9; i++) {
            row[i] = new HashSet<char>();
            col[i] = new HashSet<char>();
            box[i] = new HashSet<char>();
        }

        for (int r = 0; r < board.Length; r++) {
            for (int c = 0; c < board[r].Length; c++) {
                char elem = board[r][c];
                // skipping the separators
                if (elem == '.') {
                    continue;
                }

                //cannot add
                if (!row[r].Add(elem)) {
                    return false;
                }

                if (!col[c].Add(elem)) {
                    return false;
                }
                
                int b = (3 * (r / 3)) + (c / 3);
                if (!box[b].Add(elem)) {
                    return false;
                }
            }
        }

        return true;
    }
}