public class Solution {
    public int RemoveElement(int[] nums, int val) {

        int left_pointer = 0;
        int right_pointer = nums.Length-1;

        while (left_pointer <= right_pointer){

            if (nums[left_pointer] == val){
                nums[left_pointer] = nums[right_pointer];
                right_pointer--;

            }

            else{
                left_pointer++;
            }
        }

        return left_pointer;
    }
    

       
}