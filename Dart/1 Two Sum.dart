class Solution {
  List<int> twoSum(List<int> nums, int target) {
    //A Map to store value and their index
    Map<int, int> numToIndex = {};

    //Enumerate through the list.
    for (int i = 0; i < nums.length; i++) {
      //Check if difference between target and current value exist in map.
      if (numToIndex.containsKey(target - nums[i])) {
        //If yes, return its index and current index.
        return [numToIndex[target - nums[i]]!, i];
      }

      //Else add value and its index.
      numToIndex[nums[i]] = i;
    }

    //Else return blank list, since no elements add up to target.
    return [];
  }
}

void main() {
  Solution sol = Solution();
  print(sol.twoSum([1, 6, 7, 7, 9, 45], 7));
}
