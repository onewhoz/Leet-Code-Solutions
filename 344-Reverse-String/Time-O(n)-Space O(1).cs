public class Solution {
    public void ReverseString(char[] s) {
        int start = 0, end = s.Length - 1;
        char temp;
        while (start < end){
            temp = s[start];
            s[start] = s[end];
            s[end] = temp;
            start++;
            end--;
        }
        
    }
}
