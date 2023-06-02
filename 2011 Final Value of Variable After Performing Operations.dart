class Solution {
  int finalValueAfterOperations(List<String> operations) {
    //Initialize Summation variable.
    int finalValue = 0;

    //Traverse through the operations list.
    operations.forEach((x) {
      //If current operations contains '+', increment finalValue by 1. Else do the decrement by 1.
      finalValue += x.contains("+") ? 1 : -1;
    });

    //After traversing is completed, return latest value of summation variable
    return finalValue;
  }
}

void main() {
  Solution sol = Solution();
  print(sol.finalValueAfterOperations(["X++", "++X", "X--"]));
}
