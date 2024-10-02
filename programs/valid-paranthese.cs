public class Solution {
    public bool IsValid(string s) {
        Dictionary<char,char> mydict = new Dictionary<char,char> {
            {']','['},
            {')','('},
            {'}','{'}
        };
        
        Stack<char> mystack = new Stack<char>();

        foreach(char c in s){
            if(mydict.ContainsKey(c)){
                if(mystack.Count != 0 && mystack.Peek() == mydict[c]){
                    mystack.Pop();
                }else{
                    return false;
                }
            }else{
                mystack.Push(c);
            }
        }

        if(mystack.Count == 0){
            return true;
        }
        return false;
    }
}