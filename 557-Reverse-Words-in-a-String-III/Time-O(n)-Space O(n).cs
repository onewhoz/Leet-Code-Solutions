public class Solution {
    public string ReverseWords(string s) {
        int pos = 0;
        char[] result = s.ToCharArray();
        for(int i = 0; i <= result.Length -1; i++){
            if(result[i] ==' ' || i == result.Length -1){
                if (i != result.Length -1) {
                    result = reverse(pos, i-1, result);
                pos = i +1;
                }
                else result = reverse(pos, i, result);
                
                
            }
        }
        return new string(result);
    }
    char []reverse(int start, int end, char[] arr){
       
        while(start<end){
            char temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
        return arr;
        
    }
}
