public class MinStack {

    private List<int> stack; 
    private List<int> minstack;

    public MinStack() {
        stack = new List<int>(); 
        minstack = new List<int>();
    }
    
    public void Push(int val) { 
        stack.Add(val);
        if(minstack.Count == 0 || val <= minstack[minstack.Count - 1 ]){
            minstack.Add(val);
        }
    }
    
    public void Pop() {
        if(stack.Count != 0){
            if(stack[stack.Count -1 ] == minstack[minstack.Count - 1 ]){
                minstack.RemoveAt(minstack.Count -1);
        }
             stack.RemoveAt(stack.Count - 1);
        }


    }
    
    public int Top() {
        return stack.Count != 0 ? stack[stack.Count - 1] : 0;
    }
    
    public int GetMin() {
        return minstack.Count != 0 ? minstack[minstack.Count - 1] : int.MaxValue;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */