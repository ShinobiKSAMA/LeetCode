class Solution {
  int romanToInt(String s) {
    //Declare Comman Romans and their correspndants
    Map<String, int> romans = {
      "I": 1,
      "V": 5,
      "X": 10,
      "L": 50,
      "C": 100,
      "D": 500,
      "M": 1000,
    };

    //Get last place's correspondant
    int result = romans[s[s.length - 1]]!;

    //Traverse through remaining String in reverse order
    for (int i = s.length - 2; i >= 0; i--) {
      //Check if current and right value are same
      result = romans[s[i]]! >= romans[s[i + 1]]!
          //If yes add cuurent's correspondant to result
          ? result + romans[s[i]]!
          //If no subtarct cuurent's correspondant from result
          : result - romans[s[i]]!;
    }

    return result;
  }
}

void main() {
  Solution sol = Solution();
  print(sol.romanToInt("DCCXLIII"));
}
