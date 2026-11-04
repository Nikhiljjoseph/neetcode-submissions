public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int output=0;
        int left=0;
        var set=new HashSet<char>();
        for(int right=0;right<s.Length;right++){
            while(set.Contains(s[right])){
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            output=Math.Max(output,right-left+1);
        }
        return output;
    }
}
