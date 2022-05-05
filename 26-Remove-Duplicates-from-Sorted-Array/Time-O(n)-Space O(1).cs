public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int temp = 0, index = 0;
        for (int i = 0; i <= nums.Length - 1; i++){
            if (i == 0 || nums[i] != temp){
                temp = nums[i];
                nums[index] = nums[i];
                index++;
            }
        }
        return index;
        
    }
}
