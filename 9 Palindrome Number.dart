class Solution {
  bool isPalindrome(int x) {
    //Integer variable to create revrse of the number.
    int rev = 0;

    //Temp varible to calculate reverse.
    int tmp = x;

    //Until tmp becomes 0, keep destroying the tmp.
    while (tmp > 0) {
      //Store new value after destruction
      final digit = tmp % 10;
      //Add that digit to already stored rev.
      rev = rev * 10 + digit;
      //And get remiander.
      tmp = tmp ~/ 10;
    }

    //If rev and x are still same, it is Palindrome
    return rev == x;
  }
}

void main() {
  Solution sol = Solution();
  print(sol.isPalindrome(547));
}
