public class Solution {
    public int MaxSubArray(int[] nums) {
        int MaxSoFar = nums[0];
        int tempSum = 0;
       for (int i=0; i<nums.Length; i++) {
		tempSum += nums[i];
		if (nums[i] > tempSum) {
			tempSum = nums[i];
		}
		if (tempSum > MaxSoFar) { 
			MaxSoFar = tempSum; 
		}
	}
      return MaxSoFar;
        
    }
}
