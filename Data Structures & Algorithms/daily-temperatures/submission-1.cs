public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res= new int[temperatures.Length];
        // if(temperatures[temperatures.Length-2]>=temperatures[temperatures.Length-1]){
        //     temperatures[temperatures.Length-2]=0;
        // }
        // else{
        //       temperatures[temperatures.Length-2]= 1;
        // }
        res[temperatures.Length-1]=0;
        // if(temperatures.Length<2) return res;

        for(int i=0;i<temperatures.Length-1;i++){
            int currTemp=temperatures[i];
            int j=i+1,count=0;
            Console.WriteLine($"temp:{currTemp},{j}");
            while(j<temperatures.Length){
                Console.WriteLine($"j:{j},{temperatures[j]}");
             if(currTemp>=temperatures[j]){
                j++;
                continue;
             }
             else{
                res[i]= j-i;
                break;
             }
            }
        }
        return res;
        
    }
}
