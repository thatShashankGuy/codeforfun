class Solution:
    def simplifyPath(self, path: str) -> str:
        stack = [] 
        pathArray = path.split("/")

        for c in pathArray:
            if c == "" or c == ".":
                continue
            elif c == "..":
                if stack:
                    stack.pop()
            else:
                stack.append(c)
            
        return "/" + "/".join(stack)