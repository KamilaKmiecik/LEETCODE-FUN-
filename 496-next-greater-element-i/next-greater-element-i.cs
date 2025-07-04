public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
      //dict of next greater elements
        Dictionary<int, int> nextGreater = new Dictionary<int, int>();

        //stack can help find greater elements
        Stack<int> stack = new Stack<int>();


        //poping off elements when we find a greater one - solves the Max too
        //and the last element (that doesnt have a next element)

        foreach (var num in nums2)
        {
            //stack peek return the next element
            while(stack.Count > 0 && num > stack.Peek())
            {
                //when there's a smaller element, assingn it to a variable
                int smol = stack.Pop();
                //dict um1 - num2
                nextGreater[smol] = num;
            }
            stack.Push(num);
        }


        while (stack.Count > 0)
        {
            nextGreater[stack.Pop()] = -1;
        }

        //the values is the dictionary are the greater elements - truning it into an array
        int[] result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            result[i] = nextGreater[nums1[i]];
        }

        return result;
            }
}
