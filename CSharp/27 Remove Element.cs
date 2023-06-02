public class Solution {
    public int RemoveElement(int[] nums, int val) {
        //Check if numsList is empty. If yes, there will be no elements. So count will be 0.
        if (nums.Length == 0) return 0;

        //Initialize counting varuble.
        int count = 0;

        //Traverse through the nums list.
        foreach (int num in nums) {
            //Check if current element is not value.
            if(num != val){
                //If it is not value, increment the counting variable and add element at count index.
                nums[count++] = num;
            }
        }

        //After traversing, return latest value of counting variable.
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] nums = new int[] {1, 6, 7, 7, 9, 45};
        Console.WriteLine(sol.RemoveElement(nums, 7));
    }
}