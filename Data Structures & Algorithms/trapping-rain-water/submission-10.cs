public class Solution {
    public int Trap(int[] height) {
        var prefix = new int[height.Length];
        var suffix = new int[height.Length];
        prefix[0] = height[0];
        suffix[height.Length-1] = height[height.Length-1];
        int output = 0;
        for(int i=1; i<height.Length; i++){
            prefix[i]=Math.Max(prefix[i-1],height[i]);
        }
        for(int i=height.Length-2; i>=0; i--){
            suffix[i]=Math.Max(suffix[i+1],height[i]);
        }      
        for(int i=0; i<height.Length; i++){
            output += Math.Min(prefix[i], suffix[i]) - height[i];
        }
        return output;
    }
}
