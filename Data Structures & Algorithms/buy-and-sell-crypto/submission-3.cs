public class Solution {
    public int MaxProfit(int[] prices) {
        var min = new int[prices.Length];
        int profit = 0;
        min[0]=prices[0];
        for(int i=1; i<min.Length;i++){
            if(min[i-1]<prices[i])
                min[i]=min[i-1];
            else
                min[i]=prices[i];
        }
        for(int i=1; i<min.Length;i++){
            int diff = Math.Abs(prices[i]-min[i]);
            profit=Math.Max(diff,profit);
        }
        return profit;
    }
}
