public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> result = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];
            if (result.ContainsKey(diff) == true) return new [] {result[diff], i};
            else if (result.ContainsKey(nums[i]) == false)result.Add(nums[i], i);
        }
         return new [] { 0, 0};
        }
       
    }

//Using hashmap
