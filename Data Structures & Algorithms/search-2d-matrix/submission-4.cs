public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows=matrix.Length;
        int cols=matrix[0].Length;
        int left=0;
        int right=cols*rows-1;
        while(left<=right){
            int center = (left+right)/2;
            if(target>matrix[center/cols][center%cols])
                left=center + 1;
            else if(target<matrix[center/cols][center%cols])
                right=center- 1;
            else if(target == matrix[center/cols][center%cols])
                return true;
        }
        return false;

    }
}
