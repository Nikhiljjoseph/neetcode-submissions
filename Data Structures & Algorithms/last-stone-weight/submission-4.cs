public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        foreach(int num in stones){
            queue.Enqueue(num,101-num);
        }
        while(queue.Count>1){
            int first = queue.Dequeue();
            int second = queue.Dequeue();
            int result = Math.Abs(first-second);
            if(result!=0) queue.Enqueue(result,101-result);
        }
        if(queue.Count==0) return 0;
        else return queue.Dequeue();
    }
}
