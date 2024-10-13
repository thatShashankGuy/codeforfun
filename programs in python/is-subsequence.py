class Solution:
    def isSubsequence(self, s: str, t: str) -> bool:
        # if s is subsequence of t then traverse through s and t and if 
        # we can travse through all of s then s is subsequence else not . 

        i = 0 
        j = 0 

        while i < len(s) and j < len(t): 
            if s[i] == t[j]:
                i+= 1
            j += 1

        print(i)
        return i == len(s)  