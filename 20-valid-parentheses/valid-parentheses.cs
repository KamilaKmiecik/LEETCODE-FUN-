public class Solution {
    public bool IsValid(string s)
    {
        if(s.Length % 2 != 0)
        return false;

    //we're only adding the right side
    Stack<char> stack = new Stack<char>();

    foreach (char c in s)
    {
        //it has to always be a sequence of 
        //1. left side - { [ (
        //2. right side - ) } ] 
    
        //if it's 1. add 2. to check later
        if (c == '(') stack.Push(')');
        else if (c == '{') stack.Push('}');
        else if (c == '[') stack.Push(']');
        else
        {
            //check by removing a fitting 2.
            if (stack.Count == 0 || stack.Pop() != c)
                return false;
        }
    }

    //if the stack is empty, then that means every 1. hais a 2. pair
    return stack.Count == 0;

  }
}