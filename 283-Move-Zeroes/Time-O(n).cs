public class Solution {
    public void MoveZeroes(int[] nums) {
        int y = 0;
        for (int i = 0; i < nums.Length; i++){
            if(nums[i] != 0){
                nums[y] = nums[i];
                y++;
            }
            
            if(i == nums.Length -1){
                while (y < nums.Length){
            nums[y] = 0;
            y++;
            }
        }
            
        }
    }
}
