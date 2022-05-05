/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
      
         int search(int start,int end){
             if(start>end) return -1;
             if(guess(start)==0) return start;
             if(guess(end)==0) return end;
             
             int mid = start+(end-start)/2;
             if(guess(mid)==0) return mid;
             else if(guess(mid)==-1) return search(start+1,mid-1);
             else return search(mid+1,end-1);
         }
        return search(1,n);
        
 
    }
}
