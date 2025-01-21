public class Solution {
    public int PivotIndex(int[] nums) {

      

        
        int l=0;
        int n=nums.Length;
        long totalSum=0;
        long lSum=0;

        foreach(int x in nums){

            totalSum+=x;
        }

        for(int i=0;i<n;i++){

            long rSum=totalSum-nums[i]-lSum;

            if(lSum==rSum){
                return i;
            }
            lSum+=nums[i];
        }

        

        return -1;
    }
}