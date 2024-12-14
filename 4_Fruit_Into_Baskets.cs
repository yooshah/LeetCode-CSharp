public class Solution {
    // Complete this function
    public int TotalFruits(List<int> arr) {
        // Your code here
        
        Dictionary<int,int> basket=new Dictionary<int,int>();
        int l=0;
        int r=0;
        int res=0;
        
        int n=arr.Count;
        
        while(r<n){
            
            
             if (!basket.ContainsKey(arr[r])) {
                basket[arr[r]] = 0;
            }
            basket[arr[r]] += 1;
            
            if(basket.Count<=2){
                res=Math.Max(res,r-l+1);
            }
            
            while(basket.Count>2){
                basket[arr[l]]-=1;
                if(basket[arr[l]]==0){
                    basket.Remove(arr[l]);
                }
                l++;
            }
            
            r++;
        }
        return res;
        
    }
}