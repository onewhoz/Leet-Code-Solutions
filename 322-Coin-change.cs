public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int [amount + 1];
        dp[0] = 0;
        for(int i = 1; i < dp.Length; i++){
            dp[i] = amount + 1;
        }
        
        for(int x = 1; x < amount + 1; x++){
            for(int y = 0; y < coins.Length; y++){
                if(x - coins[y] >= 0){
                    dp[x] = Math.Min(dp[x], 1 + dp[x - coins[y]]);
                }
            }
        }
        if (dp[amount] != amount + 1) return dp[amount];

        else return -1;
    }
}
