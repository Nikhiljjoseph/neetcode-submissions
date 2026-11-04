public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] a;
        int[] b;
        if(nums1.Length < nums2.Length){
            a = nums1;
            b = nums2;
        }
        else{
            a = nums2;
            b = nums1;
        }
        int left=0;
        int right=a.Length;
        int totalLength = a.Length+b.Length;
        int half= (totalLength+1)/2;
        while(left<=right){
            int partitionA=left+(right-left)/2;
            int partitionB=half-partitionA;
            int leftA=partitionA==0?int.MinValue:a[partitionA-1];
            int rightA=partitionA==a.Length?int.MaxValue:a[partitionA];
            int leftB=partitionB==0?int.MinValue:b[partitionB-1];
            int rightB=partitionB==b.Length?int.MaxValue:b[partitionB];
            if(leftA<=rightB && leftB<=rightA){
                if(totalLength%2 == 1)
                    return Math.Max(leftB,leftA);
                else
                    return (Math.Max(leftB,leftA)+Math.Min(rightB,rightA))/2.0;
            }
            else if(leftA>rightB)
                right = partitionA-1;
            else
                left = partitionA+1;
        }
        return 0;
    }
}
