public class Solution {
    public string SimplifyPath(string path) {
        string[] pathArray = path.Split('/');

         Stack<string> stack = new Stack<string>();

        foreach(string c in pathArray){
            if(string.IsNullOrEmpty(c) || c == "."){
                continue;
            }else if(c == "..") {
                if(stack.Count > 0){
                    stack.Pop();
                }
            }else{
                stack.Push(c);
            }
        }

        string simplePath = "/" + string.Join("/", stack.Reverse());
        return simplePath;
    }
}