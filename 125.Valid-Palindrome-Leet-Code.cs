public class Solution {
    public bool IsPalindrome(string s) {
        int end = s.Length - 1;
        int start = 0;
        while (start <= end){
            while((Char.IsLetterOrDigit(s[start]) == false) && (start < end)) start++;
            while((Char.IsLetterOrDigit(s[end]) == false) && (end > start)) end--;
            if(start == end && Char.IsLetterOrDigit(s[end]) == false) return true;
            if(Char.ToLower(s[start]) != Char.ToLower(s[end])) return false;
            start++;
            end--;
        }
        return true;
    }
}
