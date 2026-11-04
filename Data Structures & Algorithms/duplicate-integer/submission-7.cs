public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool output = false;
        HashSet<int> seen = new HashSet<int>();
        foreach(int num in nums){
            if(!seen.Add(num))
                output = true;
        } 
        return output;      
    }
}