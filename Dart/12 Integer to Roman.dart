class Solution {
  String intToRoman(int num) {
    //List of Romans for Thousands
    List<String> thousands = ["", "M", "MM", "MMM"];

    //List of Romans for Hundreds
    List<String> hundreds = [
      "",
      "C",
      "CC",
      "CCC",
      "CD",
      "D",
      "DC",
      "DCC",
      "DCCC",
      "CM"
    ];

    //List of Romans for Tens
    List<String> tens = [
      "",
      "X",
      "XX",
      "XXX",
      "XL",
      "L",
      "LX",
      "LXX",
      "LXXX",
      "XC"
    ];

    //List of Romans for Ones
    List<String> ones = [
      "",
      "I",
      "II",
      "III",
      "IV",
      "V",
      "VI",
      "VII",
      "VIII",
      "IX"
    ];

    //Concatenation of all numbers' roman correspondent
    return thousands[num ~/ 1000] + //get 1000th place
        hundreds[num % 1000 ~/ 100] + //get 100th place
        tens[num % 100 ~/ 10] + //get 10th place
        ones[num % 10]; //get 1st place
  }
}

void main() {
  Solution sol = Solution();
  print(sol.intToRoman(743));
}
