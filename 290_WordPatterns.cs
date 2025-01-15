public class Solution {
    public bool WordPattern(string pattern, string s) {

   List<string> wordList=s.Split(" ").ToList();

   Dictionary<char,string> hash=new Dictionary<char,string>();
   Dictionary<string,char> hash2=new Dictionary<string,char>();

   if(pattern.Length!=wordList.Count){
    return false;
   }



   for(int i =0;i<pattern.Length;i++){

    if(!hash.ContainsKey(pattern[i])){
        hash[pattern[i]]= wordList[i];
    }
    else{
        if(hash[pattern[i]]!=wordList[i]){
            return false;
        }
    }
     if(!hash2.ContainsKey(wordList[i])){

        hash2[wordList[i]]= pattern[i];
    }
    else{
         if(hash2[wordList[i]]!=pattern[i]){
            return false;
        }
    }


   }
        return true;
    }
}