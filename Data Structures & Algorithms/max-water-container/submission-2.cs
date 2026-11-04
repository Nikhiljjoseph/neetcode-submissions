public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int max = 0;
        while(left<right){
            int area = (right-left)*Math.Min(heights[left],heights[right]);
            max = Math.Max(area,max);
            if(heights[left]<heights[right])
                left++;
            else
                right--;
        }
        return max;
    }
}
