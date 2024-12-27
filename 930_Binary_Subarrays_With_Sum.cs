public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {

        int res1=SubArryFinder(nums,goal);
        int res2=SubArryFinder(nums,goal-1);

        return res1-res2;


       
    }
    
    public int SubArryFinder(int [] arr,int target)
    {
        int l=0;
        int r=0;
        int  n=arr.Length;
        int curSum=0;
        int count=0;

        while(r<n){


            if(target<0){

                return 0;
            }
            curSum+=arr[r];

            while(curSum>target)
            {
                curSum-=arr[l];
                l++;
            }
            count+=(r-l+1);
            r++;
        }
            return count;

    }

}