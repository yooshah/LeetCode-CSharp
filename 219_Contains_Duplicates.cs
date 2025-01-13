public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {





  if(k==0){
            return false;
        }

        HashSet<int> store=new HashSet<int>();
        int n=nums.Length;

        for(int i=0;i<n;i++){

            if(store.Contains(nums[i])){
                return true;
            }

            store.Add(nums[i]);

            while(store.Count>k){
                store.Remove(nums[i-k]);
            }
        }

        return false;
      
    //   int l=0;
    //   int r=1;

    //   int n=nums.Length;
    //   if(k==0){
    //     return false;
    //   }

    //   while(r<n){

    //      while((r-l)>k){
    //         l++;
    //     }

    //     if(nums[l]==nums[r]){
    //         Console.WriteLine($" {l}, {r}");
    //         return true;
    //     }

       
    //     r++;
        
    //   }
    //   return false;
        



      
    }
}