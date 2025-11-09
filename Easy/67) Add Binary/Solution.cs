public class Solution {
    public string AddBinary(string a, string b) {
        StringBuilder result = new StringBuilder();
        int a_len = a.Length - 1;
        int b_len = b.Length - 1;
        int carry = 0;
        
        
        while (a_len >= 0 || b_len >= 0 || carry > 0) {
            int sum = carry;
            
            if (a_len >= 0) {
                sum += a[a_len] - '0';  
                a_len--;
            }
            
            if (b_len >= 0) {
                sum += b[b_len] - '0';
                b_len--;
            }
            
            result.Insert(0, sum % 2);  
            carry = sum / 2;           
        }
        
        return result.ToString();
    }
}