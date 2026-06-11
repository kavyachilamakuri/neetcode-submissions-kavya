public class Solution {
    public int MaxArea(int[] heights) {
         int i=0,j=heights.Length-1,area=Int16.MinValue;
         for(i=0;i<heights.Length-1;i++){
            j=heights.Length-1;
           while(j>i){
            int breadth=j-i;
            int length=Math.Min(heights[i],heights[j]);
            // int length=heights[j]!=heights[i]?Math.Abs(heights[j]-heights[i]):heights[j];
            // Console.WriteLine($"i:{i},j:{j},l:{length},b:{breadth},a:{breadth*length}");
            area=Math.Max(area,breadth*length);
            j--;
           }
         }
         return area;
        
    }
}
