public class Solution {
    public bool IsPalindrome(int x) 
    {
        string firstInput = x.ToString();
   
        char[] charArray =  firstInput.ToCharArray();
        char[] reverseArray = firstInput.ToCharArray();
        Array.Reverse(reverseArray);

        return charArray.SequenceEqual(reverseArray);
        
        //if (charArray == reverseArray)
        //{
            //return true;

        //}

        //else
        //{
            //return false;
        //}

    }
}