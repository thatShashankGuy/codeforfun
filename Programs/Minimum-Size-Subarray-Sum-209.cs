public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0; 
        int total = 0; 
        int min = int.MaxValue;

        for(int right = 0; right < nums.Length ; right++ ){
            total += nums[right];
            while(total >= target){
                min = Math.Min(min,right - left + 1);
                total -= nums[left];
                left++;
            }
        }

        if(min == int.MaxValue){
            return 0;
        }

        return min;
    }
}