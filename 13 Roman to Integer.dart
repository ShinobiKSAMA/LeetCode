class Solution {
  int romanToInt(String s) {
    Map<String, int> romans = {
      "I": 1,
      "V": 5,
      "X": 10,
      "L": 50,
      "C": 100,
      "D": 500,
      "M": 1000,
    };

    int result = romans[s[s.length - 1]]!;

    for (int i = s.length - 2; i >= 0; i--) {
      result = romans[s[i]]! >= romans[s[i + 1]]!
          ? result + romans[s[i]]!
          : result - romans[s[i]]!;
    }

    return result;
  }
}

void main() {
  Solution sol = Solution();
  print(sol.romanToInt("III"));
}
