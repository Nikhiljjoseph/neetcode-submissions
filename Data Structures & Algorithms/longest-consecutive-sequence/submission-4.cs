public class Solution {
    public int LongestConsecutive(int[] nums) {
        var start = new HashSet<int>(nums);
        int longest = 0;
        foreach(int num in nums){
            if(!start.Contains(num-1)){
                int curr = num;
                int count = 1;
                while(start.Contains(curr+1)){
                    count++;
                    curr++;
                }
                longest = Math.Max(count, longest);
            }
        }
        return longest;
    }
}
