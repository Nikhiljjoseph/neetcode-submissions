public class Solution {
    public bool IsAnagram(string s, string t) {
        var map = new Dictionary<char,int>();
        if(s.Length != t.Length)
            return false;
        foreach(char c in s){
            if(!map.ContainsKey(c))
                map[c]=0;
            map[c]++;
        }
        foreach(char c in t){
            if(!map.ContainsKey(c))
                return false;
            map[c]--;
            if(map[c] < 0)
                return false;            
        }
        return true;

    }
}
