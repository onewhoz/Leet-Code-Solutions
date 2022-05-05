public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> myhash1 = new HashSet<int>();
         foreach(var val in nums)
        {
            if(myhash1.Contains(val)) return true;
            myhash1.Add(val);
        }
      
        return false;
    }
}
