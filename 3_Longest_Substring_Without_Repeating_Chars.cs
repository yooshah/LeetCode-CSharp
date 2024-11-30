public class Solution {
    public int LengthOfLongestSubstring(string s) {

        Dictionary <char,int> hash=new Dictionary <char ,int>();

        int left=0,right=0;

        int sublen=0;
        int n=s.Length;


        while(right<n){ 

            if(hash.ContainsKey(s[right])){
                left=Math.Max(hash[s[right]]+1,left);
            } 

            hash[s[right]]=right;

            sublen=Math.Max(right-left+1,sublen);

            right++;
        }
        return sublen;
    }
        
}