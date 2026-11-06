public class Solution {
    public int FindDuplicate(int[] nums) {
        var bag = new HashSet<int>();
        foreach(int num in nums){
            if(bag.Contains(num))
                return num;
            bag.Add(num);
        }
        return -1;
    }
}
