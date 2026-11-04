public class Solution {
    public bool IsValid(string s) {

        if(s.Length==0)
            return true;
        if(s[0]==')'|s[0]=='}'|s[0]==']')
            return false;

        var stack= new Stack<char>();

        for(int i=0; i<s.Length; i++){
            if(s[i]=='('|s[i]=='{'|s[i]=='[')
                stack.Push(s[i]);

            else if(stack.Count>0 && s[i]==')'){
                if(stack.Pop() != '(')
                    return false;
            }
            else if(stack.Count>0 && s[i]=='}'){
                if(stack.Pop() != '{')
                    return false;
            }
            else if(stack.Count>0 && s[i]==']'){
                if(stack.Pop() != '[')
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
