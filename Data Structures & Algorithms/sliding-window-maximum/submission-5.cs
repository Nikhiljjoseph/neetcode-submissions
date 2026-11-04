public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int[] result = new int[nums.Length-k+1];
        int count=0;
        var window = new LinkedList<int>();
        for(int i=0; i<nums.Length; i++){
            if(window.Count>0 && window.First.Value<=i-k)
                window.RemoveFirst();
            while(window.Count>0 && nums[window.Last.Value]<nums[i])
                window.RemoveLast();
            window.AddLast(i);    
            if(i>=k-1)
                result[count++]=nums[window.First.Value];            
        }
        return result;
    }
}
