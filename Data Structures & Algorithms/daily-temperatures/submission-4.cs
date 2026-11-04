public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        var output = new int[temperatures.Length];
        for(int i=temperatures.Length-1;i>=0;i--){
            while(stack.Count > 0 && temperatures[stack.Peek()]<=temperatures[i]){
                stack.Pop();
            }
            if(stack.Count>0)
                output[i]=stack.Peek()-i;
            else
                output[i]=0;
            stack.Push(i);
        }
        return output;
    }
}
