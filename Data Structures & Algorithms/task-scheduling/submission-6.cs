public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var map = new Dictionary<char,int>();
        var queue = new PriorityQueue<int,int>();
        var buffer = new Queue<(int task,int time)>();
        int time = 0;
        foreach(char task in tasks){
            if(map.ContainsKey(task))
                map[task]++;
            else
                map[task]=1;
        }
        foreach(char key in map.Keys){
            queue.Enqueue(map[key],-map[key]);
        }
        while(queue.Count > 0 || buffer.Count > 0){
            if(queue.Count > 0){
                int task = queue.Dequeue();
                task--;
                if(task != 0) buffer.Enqueue((task,time+n));
            }
            if(buffer.Count != 0 && buffer.Peek().time == time ){
                int taskB = buffer.Dequeue().task;
                queue.Enqueue(taskB,-taskB);
            }
            time++;
        }
        return time;
    }
}
