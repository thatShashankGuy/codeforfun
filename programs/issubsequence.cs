public class Solution {
    public bool IsSubsequence(string s, string t) {
        int l = 0;
        int r = 0;

        Console.WriteLine(s.Length);

        while(l < s.Length && r < t.Length){
            if(s[l] == t[r]){
                l++;
            }

            r++;
        }

        if(l == s.Length){
            return true;
        }

        return false;
    }
}