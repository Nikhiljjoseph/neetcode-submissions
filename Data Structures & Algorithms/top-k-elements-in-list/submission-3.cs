public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        foreach (var num in nums){
            if(!freq.ContainsKey(num))
                freq[num] = 0;
            freq[num]++;
        }
        var buckets = new List<int>[nums.Length+1];
        foreach (var kvp in freq)
        {
            if(buckets[kvp.Value] == null)
                buckets[kvp.Value] = new List<int>();

            buckets[kvp.Value].Add(kvp.Key);
        }
        var result = new List<int>();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] == null) continue;
            result.AddRange(buckets[i]);
        }
        return result.Take(k).ToArray();
    }
}
