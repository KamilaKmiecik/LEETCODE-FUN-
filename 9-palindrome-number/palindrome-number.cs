public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false; 

   
        var arr = new int[10]; 
        int i = 0; 
         
        int x2 = x; 
        int j = 10;
        while(x2 > 0)
        { 
            arr[i] = x2 % 10;
            x2 /= 10; 
            i++;
        }

        Console.WriteLine(i.ToString());
        Console.WriteLine(arr.Length.ToString());
       // int l = arr.Lenght; 
        for (int k = 0; k < i; k++)
            if (arr[k] != arr[i - k -1])
                return false;

        return true; 
    }
}