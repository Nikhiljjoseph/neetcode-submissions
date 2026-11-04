public class Solution {
    public bool IsValid(string s) {
        var stack= new LinkedList<char>();
        var forward= new Dictionary<char,int>{{'(',1},{'{',2},{'[',3}};
        var reverse= new Dictionary<char,int>{{')',1},{'}',2},{']',3}};
        if(s.Length == 0)
            return true;
        if(reverse.ContainsKey(s[0]))
            return false;
        for(int i=0; i<s.Length;i++){
            if(!forward.ContainsKey(s[i]) && !reverse.ContainsKey(s[i]))
                return false;
            if(forward.ContainsKey(s[i]))
                stack.AddFirst(s[i]);
            else if(reverse.ContainsKey(s[i]) && stack.Count>0){
                if(reverse[s[i]]==forward[stack.First.Value])
                    stack.RemoveFirst();
                else
                    return false;
            }
            else
                return false;           
        }
        if(stack.Count==0)
            return true;
        return false;
    }
}
