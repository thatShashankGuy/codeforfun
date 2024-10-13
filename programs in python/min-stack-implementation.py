class MinStack:

    def __init__(self):
        self.stack = []
        self.minstack = []

    def push(self, val: int) -> None:
        self.stack.append(val)
        if len(self.minstack) == 0 or val <= self.minstack[- 1]:
            self.minstack.append(val)

    def pop(self) -> None:
        if len(self.stack) != 0:
            if self.minstack[-1] == self.stack[-1]:
                self.minstack.pop()
            self.stack.pop()

        

    def top(self) -> int:
        if len(self.stack )== 0:
            raise IndexError["stack is empty"]
        return self.stack[-1] 
        

    def getMin(self) -> int:
        if len(self.minstack) == 0 :
            raise IndexError["stack is empty"]
        
        return  self.minstack[-1]


# Your MinStack object will be instantiated and called as such:
# obj = MinStack()
# obj.push(val)
# obj.pop()
# param_3 = obj.top()
# param_4 = obj.getMin()