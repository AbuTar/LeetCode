public class Solution {
    public int StrStr(string haystack, string needle) {

        for (int i =0; i <= haystack.Length - needle.Length; i++){
            bool isFound = true;

            for (int j = 0; j < needle.Length; j++){

                if (needle[j] == haystack[i+j]){
                    continue;   
                }

                else{
                    isFound = false;
                }
            }

            if (isFound == true){
                return (i);
            }
            
            else{
                continue;
            }


        }

        return -1;
        
    }
}