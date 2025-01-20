
using  System.Text;
public class Solution {
    public bool RepeatedSubstringPattern(string s) {

        


    int n=s.Length;

    for(int i=1;i<=n/2;i++){
        if(n%i==0){
           
            string res=s.Substring(0,i);
            
            StringBuilder result=new StringBuilder();

            for(int j=0;j<n/i;j++){

                result.Append(res);
            }
            if(result.ToString()==s){
                return true;
            }

        }
    }
    return false;



      
    }

   
}