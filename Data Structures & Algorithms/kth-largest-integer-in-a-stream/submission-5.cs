public class KthLargest {
    public PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
    private int limit = 0;
    public KthLargest(int k, int[] nums) {
        limit = k;
        foreach(int num in nums){
            queue.Enqueue(num,num);
            if(queue.Count > k)
                queue.Dequeue();
        }
    }
    
    public int Add(int val) {
        queue.Enqueue(val,val);
        if(queue.Count > limit)
            queue.Dequeue();
        return queue.Peek();
    }
}
