public class Solution {
    public int CharacterReplacement(string s, int k) {
        int output=0;
        int left=0;
        int maxFreq=0;
        var map = new Dictionary<char,int>();
        for(int right=0;right<s.Length;right++){
            if(!map.ContainsKey(s[right]))
                map.Add(s[right],1);
            else
                map[s[right]]++;
            
            maxFreq=Math.Max(map[s[right]],maxFreq);

            while((right-left+1)-maxFreq > k){
                map[s[left]]--;
                left++;
            }

            output = Math.Max(output,right-left+1);
        }
        return output;
    }
}
