public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        foreach(string s in tokens){
            if(int.TryParse(s,out int num))
                stack.Push(num);
            else if(s=="+"){
                int ans = stack.Pop()+stack.Pop();
                stack.Push(ans);
            }
            else if(s=="-"){
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b-a);
            }
            else if(s=="*"){
                int ans = stack.Pop()*stack.Pop();
                stack.Push(ans);
            }
            else if(s=="/"){
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b/a);
            }
        }
        return stack.Pop();
    }
}
