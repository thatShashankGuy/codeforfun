class Solution{
        public static void Rotate(int[] nums, int k) {
            k = k% nums.Length;

            RotateHelper(nums,0,nums.Length-1);
            RotateHelper(nums,0,k-1);
            RotateHelper(nums,k,nums.Length-1);

            System.Console.WriteLine(string.Join(",",nums));
        }

        private static void RotateHelper(int[] nums,int l, int r){
            int t = 0;
            while(l < r){
                t = nums[l]; 
                nums[l] = nums[r];
                nums[r] = t;
                l++;
                r--;
            }
        }
    }
