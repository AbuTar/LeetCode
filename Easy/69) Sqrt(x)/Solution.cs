public class Solution {
    public int MySqrt(int x) {

        int final = 0;

        if (x == 0){
            return x;
        }

        else if (x ==1 ){
            return x;
        }

        else{
            double a = x;
            double z = (a + (x/a));

            while (Math.Abs(a - z) >= 0.1) {

                a = z;
                z = (a + (x / a)) / 2;
            }

            final = Convert.ToInt32(Math.Floor(z));
            return final;
  
        }

        
    }
}