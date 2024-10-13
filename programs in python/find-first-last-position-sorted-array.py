from typing import List
class Solution:
    def searchRange(self, nums: List[int], target: int) -> List[int]:
        def find_left(nums,target):
            l,r = 0 , len(nums)-1

            while l <= r : 
                m = l + (r-l)//2
                if nums[m] < target:
                    l = m + 1 
                else:
                    r = m - 1 
            
            return l 
        
        def find_right(nums,target):
            l,r = 0 ,len(nums) - 1 
            while l <= r:
                m = l + (r - l )//2
                if nums[m] <= target:
                    l = m+1
                else:
                    r = m-1
            return r 
    
        left = find_left(nums,target)
        right = find_right(nums,target)

        if left <= right and left < len(nums) and nums[left] == target:
            return [left,right]
        return [-1,-1]
        
            