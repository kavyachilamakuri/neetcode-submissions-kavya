public class Solution {
    public int MaxProfit(int[] prices) {
        int profit=0;
        for(int i=0;i<prices.Length;i++){
            int j=i+1;
            while(j<prices.Length){
                if(prices[j]>=prices[i]){
                    profit=Math.Max(profit,prices[j]-prices[i]);
                }
                j++;
            }
        }
        return profit;
    }
}
