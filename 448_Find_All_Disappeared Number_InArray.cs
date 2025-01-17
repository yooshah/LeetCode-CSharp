public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {

        Dictionary<int,int> hash=new Dictionary<int,int>();

        int n=nums.Length;

        List<int> list=new List<int>();

        for(int i=0;i<n;i++){
           
           if(!hash.ContainsKey(nums[i])){
            hash[nums[i]]=1;
           }
           else{
             hash[nums[i]]+=1;
           }

        }

        for(int i=1;i<n+1;i++){

            if(!hash.ContainsKey(i)){
                list.Add(i);
            }
        }
        return list;


        
    }
}