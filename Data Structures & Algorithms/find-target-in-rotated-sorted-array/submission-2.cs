public class Solution {
    public int Search(int[] nums, int target) {
        int left=0;
        int right=nums.Length - 1;
        while(left<right){
            int curr = left+(right-left)/2;
            if(nums[curr]>nums[right])
                left=curr+1;
            else
                right=curr;
        }
        int leftActual = left;
        int rightActual = left+nums.Length -1;
        while(leftActual<=rightActual){
            int currActual = leftActual + (rightActual-leftActual)/2;
            int curr = currActual%nums.Length;
            right = rightActual%nums.Length;
            left = leftActual%nums.Length;
            if(nums[curr]<target)
                leftActual = currActual+1;
            else if(nums[curr]>target)
                rightActual = currActual-1;
            else
                return curr;
        }
        return -1;
    }
}
