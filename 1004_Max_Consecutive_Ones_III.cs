public class Solution {
    public int LongestOnes(int[] nums, int k) {

        int zeros=0;
        int res=0;
        int l=0,r=0;
        int n=nums.Length;

        while(r<n){
            if(nums[r]==0){
                zeros++;
            }
            if(zeros>k){
                if(nums[l]==0){zeros--;}
                l++;
            }
            if(zeros<=k){
                res=Math.Max(res,(r-l+1));
            }
            r++;

        }
        return res;
    }
}