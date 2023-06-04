class Solution {
  static const MAX = 2147483647;
  static const MIN = -2147483648;

  int myAtoi(String s) {
    //Enumeration variable.
    int idx = 0;

    //Variable to store result.
    int result = 0;

    //Boolean to decide sign.
    bool isNeg = false;

    //Untill there are white spaces, keep incrementing.
    while (idx < s.length && s[idx] == ' ') idx++;

    //If we encounter sign, change boolean value and increment.
    if (idx < s.length && (s[idx] == '+' || s[idx] == '-')) {
      isNeg = s[idx] == '-';
      idx++;
    }

    //Untill we keep encountering digits, keep adding it to result.
    //(s.codeUnitAt(idx) ^ 0x30) <= 9, this will return true if we have digut.
    while (idx < s.length && (s.codeUnitAt(idx) ^ 0x30) <= 9) {
      //Converting characters to numbers.
      result = result * 10 + int.parse(s[idx]);

      //If value exceeds MaxValue, break the loop.
      if (result > MAX) break;

      //Keep incrementing index.
      idx++;
    }

    //If value needs to be negative, convert it.
    result = isNeg ? -result : result;

    //If values are max, return MaxValue.
    if (result > MAX) return MAX;

    //If values are min, return MinValue.
    if (result < MIN) return MIN;

    //Return current result.
    return result;
  }
}

void main() {
  Solution sol = Solution();
  print(sol.myAtoi("-4193 with words"));
}
