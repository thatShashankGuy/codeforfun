from typing import List

class Solution:
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        left = 0 
        total = 0 
        minimum = 1000000000000

        for right in range(len(nums)):
            total += nums[right] 
            while total >= target:
                minimum = min(minimum,right - left + 1)
                total -= nums[left]
                left  += 1 
            
        return 0 if minimum == 1000000000000 else minimum