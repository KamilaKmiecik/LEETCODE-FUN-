public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        //you really could just do that 
        //Array.Copy(nums2, 0, nums1, m, n);
        //Array.Sort(nums1);
        
        for(int i = m; i < n + m; i++)
            nums1[i] = nums2[i - m];


//bubble sort
       int temp = 0, length = m + n;
       for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1 - i ; j++)
                {
                    if (nums1[j] > nums1[j + 1])
                    {
                        temp = nums1[j + 1];
                        nums1[j + 1] = nums1[j];
                        nums1[j] = temp;
                    }
                }
            }
    }
}