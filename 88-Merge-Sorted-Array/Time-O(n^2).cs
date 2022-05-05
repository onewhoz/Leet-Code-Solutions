public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

        
        for (int i = m; i < nums1.Length; i++ ){
            nums1[i] = nums2[i-m];
        }
        
        var itemMoved = false;
    do // Bubble Sort
    {
        itemMoved = false;
        for (int i = 0; i < nums1.Length - 1; i++)
        {
            if (nums1[i] > nums1[i + 1])
            {
                var lowerValue = nums1[i + 1];
                nums1[i + 1] = nums1[i];
                nums1[i] = lowerValue;
                itemMoved = true;
            }
        }
    } while (itemMoved);
        
        
    }
}
