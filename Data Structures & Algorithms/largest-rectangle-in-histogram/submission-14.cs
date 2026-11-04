public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int max=0;
        var stack = new Stack<int>();
        for(int i=0;i<heights.Length;i++){
            while(stack.Count > 0 && heights[stack.Peek()]>heights[i]){
                int index = stack.Pop();
                int left = stack.Count==0?-1:stack.Peek();
                int width=i-left-1;
                int height=heights[index];
                max=Math.Max(max,width*height);
            }
            stack.Push(i);
        }
        while(stack.Count>0){
            int index = stack.Pop();
            int left = stack.Count==0?-1:stack.Peek();
            int width=heights.Length-left-1;
            int height=heights[index];
            max=Math.Max(max,width*height);
        }
        return max;
    }
}
