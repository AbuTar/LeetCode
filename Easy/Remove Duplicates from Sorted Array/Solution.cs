public class Solution {
    public int RemoveDuplicates(int[] nums) {

        HashSet<int> duplicates = new HashSet<int>();
        int unique_num = 0;

        for (int i = 0; i < nums.Length; i++){
            if (duplicates.Contains(nums[i])){
                continue;
            }

            else{
                nums[unique_num] = nums[i];
                duplicates.Add(nums[i]);
                unique_num += 1;

            }
        }

        return unique_num;
        
        
        
        
        
        
        
        
        
        
        // This code passes test case 1, but fails test case 2
        // This is because duplicates is initated as an arary of zeroes
        // int unique_elements = 0;
        // int range = nums.Length;

        // int [] duplicates = new int[range];

        // for (int i=0; i< range; i++){

        //     if (duplicates.Contains(nums[i])){
        //         nums[i] = 999;
        //         continue;

        //     }

        //     else{
        //         duplicates[i] = nums[i];
        //         unique_elements += 1;
                

        //     }
        // }

        // int count = 0;
        // for (int i =0; i < range; i++){
        //     if (nums[i] != 999){
        //         nums[count] = nums[i];
        //         count += 1;
        //     }
        // }

        // for (int i = count; i < range; i++){
        //     nums[i] = 999;
        // }



        // return unique_elements;


        
    }
}