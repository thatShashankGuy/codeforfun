public class Solution {
    public int[] SearchRange(int[] nums, int target) {
            int[] result = new int[] {-1,-1};
            
            int l = LeftSearch(nums,target);
            int r = RightSearch(nums,target);

            if( l<= r && l < nums.Length && nums[l] == target){
                result[0] = l;
                result[1] = r;
            }
            return result; 
    }

    static int LeftSearch(int[] nums, int target){
            int l = 0;
            int r = nums.Length -  1;

            while(l <= r){
                int m = l + (r-l)/2 ; 
                if(nums[m] < target){
                    l = m + 1;
                }else{
                    r = m - 1;
                }
            }
            return l;
    }

    static int RightSearch(int[] nums, int target){
            int l = 0;
            int r = nums.Length - 1;

            while(l <= r){
                int m = l+(r - l)/2;
                if(nums[m] <= target){
                    l = m+1;
                }else{
                    r = m-1;
                }
            }

            return r;
    }
}