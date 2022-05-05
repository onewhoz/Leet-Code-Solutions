public class Solution {
    public bool IsPalindrome(int x)
            {
                string s = x.ToString();
                string Palindrome = "";
                for (int i = s.Length; i > 0; i--)
                {
                    Palindrome += s[i-1];
                }
                if (s == Palindrome)
                {
                    return true;
                }
                else { }
                return false;
            }
}
