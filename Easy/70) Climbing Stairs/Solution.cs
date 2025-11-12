public class Solution {
    public int ClimbStairs(int n) {
        int num1 = 0;
        int num2 = 0;
        int len = n-1;
        int[] Fib = new int[n];

        if (n == 1){
            return 1;
        }

        else{
            Fib[0]= 1;
            Fib[1]= 2;

            for (int i = 2; i <= len;i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[len];


        }
        
    }
}