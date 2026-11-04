public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var remaining = new (int pos,double time)[position.Length];
        var stack = new Stack<int>();
        for(int i=0;i<position.Length;i++){
            remaining[i]=(position[i],(double)(target-position[i])/speed[i]);
        }
        Array.Sort(remaining, (a,b)=>a.pos.CompareTo(b.pos));
        for(int i=remaining.Length-1;i>=0;i--){
            if(stack.Count == 0)
                stack.Push(i);
            else if(remaining[stack.Peek()].time<remaining[i].time)
                stack.Push(i);
        }
        return stack.Count;
    }
}
