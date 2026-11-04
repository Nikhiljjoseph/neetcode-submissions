public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var box = new HashSet<char>[9];

        for(int i=0; i<9; i++){
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            box[i] = new HashSet<char>();
        }

        for(int row=0; row<9; row++){
            for(int col=0; col<9; col++){
                if(board[row][col]=='.')
                    continue;
                char num = board[row][col];
                int boxIndex = (row/3)*3+(col/3);

                if(!rows[row].Add(num)||
                !cols[col].Add(num)||
                !box[boxIndex].Add(num))
                    return false;
            }
        }
        return true;
    }
}
