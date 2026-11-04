public class Solution {
    public int Search(int[] nums, int target) {
        int result = -1;
        int left=0;
        int right=nums.Length-1;
        while(left<=right){
            if(target>nums[(left+right)/2]){
                left=(left+right)/2 + 1;
            }
            else if(target<nums[(left+right)/2]){
                right=(left+right)/2 - 1;
            }
            else{
                result=(left+right)/2;
                return result;
            }
        }
        return result;
    }
}
