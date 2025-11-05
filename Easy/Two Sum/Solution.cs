public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {      
        Dictionary<int, int> numberArray = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int numPair = target - nums[i];

            if (numberArray.ContainsKey(numPair))
            {
                return new int[] 
                { 
                    numberArray[numPair], i 
                };
            }

             numberArray[nums[i]] = i;
        }

        throw new ArgumentException("No two numbers in the array add up to the target.");
    }
}