public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int> output = new List<int>();
        var map = new Dictionary<int, int>();
        foreach(int key in nums){
            if(!map.ContainsKey(key))
                map[key] = 0;
            map[key]++;
        }
        var sorted = map.OrderByDescending(x=>x.Value);
        foreach(var pair in sorted.Take(k)){
            output.Add(pair.Key);
        }
        return output.ToArray();
    }
}
