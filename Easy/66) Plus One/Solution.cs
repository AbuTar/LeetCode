public class Solution
{
    public int[] PlusOne(int[] digits)
    {

        int length = digits.Length - 1;

        for (int i = length; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i] += 1;
                return digits;
            }

            digits[i] = 0;
        }

        int[] overflow = new int[length + 2];
        overflow[0] = 1;
        return overflow;
    }
}