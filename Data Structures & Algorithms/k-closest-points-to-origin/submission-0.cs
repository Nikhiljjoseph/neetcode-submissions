public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],double> queue = new PriorityQueue<int[],double>();
        int[][] result = new int[k][];
        foreach(int[] pair in points){
            double dist = Math.Sqrt((pair[0]*pair[0]) + (pair[1]*pair[1]));
            queue.Enqueue(pair,dist);
        }
        for(int i=0; i<k; i++){
            result[i]=queue.Dequeue();
        }
        return result;
    }
}
