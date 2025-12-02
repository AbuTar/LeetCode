public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums){

            if (!set.Add(num)){

                set.Remove(num);
            }
        }

        foreach (int value in set)
        {
            return value;
        }

        return -1;
    }
}
