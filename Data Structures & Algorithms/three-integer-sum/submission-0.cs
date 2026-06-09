public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        //-4,-1,-1,0,1,2
        //-5
        // 
        List<List<int>> toReturn= new List<List<int>>();
        Array.Sort(nums);
        for(int i=0;i<nums.Length-2;i++){
           if(i>0&& nums[i]==nums[i-1]) continue;
           int left=i+1,right=nums.Length-1;
           while(left<right){
            int sum= nums[i]+nums[left]+nums[right];
            if(sum==0){
                var list= new List<int>();
                list.Add(nums[i]);
                list.Add(nums[left]);
                list.Add(nums[right]);
                toReturn.Add(list);
            
            while(left<right&&nums[left]==nums[left+1]) left++;
            while(left<right&&nums[right]==nums[right-1]) right --;
            left++;
            right--;
            }
            else if(sum<0) left++;
            else right--;
           }
        }
        return toReturn;
    }
}
