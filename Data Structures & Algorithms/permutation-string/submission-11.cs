public class Solution {
    private bool Matches(int[] a, int[] b){
        for(int i=0;i<26;i++){
            if(a[i]!=b[i])
                return false;
        }
        return true;
    }
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length)
            return false;
        var map = new int[26];
        var slide = new int[26];
        foreach(char ch in s1){
            map[ch-'a']++;
        }
        for(int i=0;i<s1.Length;i++){
            slide[s2[i]-'a']++;
        }
        if(Matches(map,slide))
                return true;
        int left=0;
        for(int right=s1.Length; right<s2.Length; right++){
            slide[s2[left]-'a']--;
            slide[s2[right]-'a']++;
            left++;
            if(Matches(map,slide))
                return true;
        }
        return false;
    }
}
