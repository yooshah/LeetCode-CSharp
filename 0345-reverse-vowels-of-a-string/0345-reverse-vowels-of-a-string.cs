public class Solution {
    public string ReverseVowels(string s) {

        int l=0;
        int r=s.Length-1;
      Dictionary<char, int> dict = new Dictionary<char, int>
{
    {'I', 1}, {'i', 1}, {'u', 1},{'U',1}, {'A', 1}, {'a', 1},
    {'O', 1}, {'o', 1}, {'E', 1}, {'e', 1}
};

        char[] arr=s.ToCharArray();

        while(l<r){

            if(!dict.ContainsKey(s[l])){
                l+=1;
            }
             if(!dict.ContainsKey(s[r])){
                r-=1;
            }
            if(dict.ContainsKey(s[l]) && dict.ContainsKey(s[r])){

                
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