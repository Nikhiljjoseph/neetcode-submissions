public class Solution {
    public string MinWindow(string s, string t) {
        if(t.Length>s.Length)
            return "";

        var map = new Dictionary<char,int>();
        var refer = new Dictionary<char,int>();
        foreach(char ch in t){
            if(!map.ContainsKey(ch))
                map[ch]=0;
            map[ch]++;
        }

        int need = map.Count;
        int have=0;
        int minLength=int.MaxValue;
        int start=0;

        int left=0;
        for(int right=0; right<s.Length; right++){
            if(!refer.ContainsKey(s[right]))
                refer[s[right]]=0;
            refer[s[right]]++;
            if(map.ContainsKey(s[right])){
            if(refer[s[right]]==map[s[right]])
                have++;}
            if(need==have){
                while(need==have){
                    int len = right-left+1;
                    if(len < minLength)
                    {
                        minLength = len;
                        start = left;
                    }
                    char ch = s[left];
                    if(refer.ContainsKey(ch)){
                        refer[ch]--;
                        if(map.ContainsKey(ch) && refer[ch]<map[ch])
                            have--;
                    }
                    left++;
                }
            }
        }
        if(minLength==int.MaxValue)
            return "";
        return s.Substring(start, minLength);;
    }
}
