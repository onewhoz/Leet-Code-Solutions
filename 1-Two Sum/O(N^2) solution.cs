// Newbie solution :)
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        
        int[] result = new int [2];
        int x = 0;
        
        while(x < nums.Length){
            int y = 0;
            while(y < nums.Length){
                if(y != x){
                    if((nums[x] + nums[y]) == target){
                    result[0] = x;
                    result[1] = y;
                    break;
                }
                }
                
                y++;
            }
            x++;
            
        }
        return result;
    }
}
