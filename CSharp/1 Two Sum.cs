public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //A Map to store value and their index
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        //Enumerate through the list.
        for (int i = 0; i < nums.Length; i++) {
            //Check if difference between target and current value exist in map.
            if (numToIndex.ContainsKey(target - nums[i])) {
                //If yes, return its index and current index.
                return new int[] {numToIndex[target - nums[i]], i};
            }

            //Else add value and its index.
            numToIndex.TryAdd(nums[i], i);
        }

        //Else return blank list, since no elements add up to target.
        return new int[] {};
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] nums = new int[] {2,5,6};
        Console.WriteLine(sol.TwoSum(nums, 8));
    }
}