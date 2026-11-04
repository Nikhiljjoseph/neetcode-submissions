public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int min=1;
        int max=piles.Max();
        int result = max;
        while(min<=max){
            int curr=min + (max - min)/2;
            long sum=0;
            foreach(int num in piles){
                sum+=(num+curr-1)/curr;
            }
            if(sum>h)
                min=curr+1;
            else if (sum<=h){
                result=curr;
                max=curr-1;
            }
        }
        return result;
    }
}
