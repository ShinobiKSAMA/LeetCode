class Solution {
  int removeElement(List<int> nums, int val) {
    //Check if numsList is empty. If yes, there will be no elements. So count will be 0.
    if (nums.isEmpty) return 0;

    //Initialize counting varuble.
    int count = 0;

    //Traverse through the nums list.
    nums.forEach((e) {
      //Check if current element is not value.
      if (e != val) {
        //If it is not value, increment the counting varible and add element at count index.
        nums[count++] = e;
      }
    });

    //After traversing, return latest value of counting variable.
    return count;
  }
}
