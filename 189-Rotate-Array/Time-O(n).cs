public class Solution {
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;
        reverse(nums, 0, nums.Length - 1);
        reverse(nums, k, nums.Length - 1);
        reverse(nums, 0, k-1);
        
}
    void reverse(int[] ar, int start, int end){
        
        while(start < end){
            int temp = ar[start];
            ar[start] = ar[end];
            ar[end] = temp;
            start++;
            end--;
            
        }
    }
}

/*

nums = "----->-->"; k =3
result = "-->----->";
reverse "----->-->" we can get "<--<-----"
reverse "<--" we can get "--><-----"
reverse "<-----" we can get "-->----->"

*\
