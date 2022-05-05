class Solution {

    public int SearchInsert(int[] nums, int target)  {
    
        
        return Search(nums, 0, nums.Length-1, target);
             
    }
    
    int Search(int[] nums, int start, int end, int target)
{
    if(start > end)
        return start;
    if(end < start)
        return end;
    int mid = start + (end-start)/2;
    if(target == nums[mid])
    {
        return mid;
    }
    else if(target > nums[mid])
    {
        return Search(nums, mid+1,end, target);
    }
    else
    {
        return Search(nums,start, mid-1,target);
    }
}
    
    
};
