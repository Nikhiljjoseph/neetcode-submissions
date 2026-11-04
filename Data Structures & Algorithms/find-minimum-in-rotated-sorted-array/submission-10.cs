public class Solution {
    public int FindMin(int[] nums) {
      int left=0;
      int right=nums.Length-1;
      while(left<right){
        int curr = left+(right-left)/2;
        if(nums[curr]>nums[right])
            left=curr+1;
        if(nums[curr]<nums[right])
            right=curr;
      }  
      return nums[left];
    }
}
