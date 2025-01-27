public class Solution {
    public string ReverseStr(string s, int k) {
       
    
    char[] arr=s.ToCharArray();
     int n=arr.Length;
    
    for(int i=0;i<n;i+=(2*k)){

        int l=i; 
        int r=Math.Min(l+k-1,n-1);

        while(l<r){
            char temp=arr[l];
            arr[l]=arr[r];
            arr[r]=temp;
            l++;
            r--;
        }
    }
    return new string(arr);
   
    }
}