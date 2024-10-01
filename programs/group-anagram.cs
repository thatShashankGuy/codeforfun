public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var myDict = new Dictionary<string,IList<string>>();

        foreach(string str in strs){
            int[] count = new int[26];
            foreach(char c in str){
                count[c - 'a']++;
            }
            string myKey = string.Join("#",count);
            if(!myDict.ContainsKey(myKey)){
                myDict[myKey] = new List<string>();
            }
            myDict[myKey].Add(str);
        }
        return new List<IList<string>>(myDict.Values);
    }
}