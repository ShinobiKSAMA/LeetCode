class Solution {
  bool isValid(String s) {
    //Map to check if checkerList has its opener.
    Map<String, String> relations = {")": "(", "}": "{", "]": "["};

    //CheckerList to store the openings.
    List<String> checker = [];

    //Traverse through all the characters from given string.
    for (String e in s.split('')) {
      //If current element is closer
      if (relations.containsKey(e)) {
        //If checkerList has elements in it and current element is closer for last element at checkerlist.
        if (checker.isNotEmpty && checker.last == relations[e]) {
          //Remove the last element, since it is correctly closed.
          checker.removeLast();
        } else {
          //If current element is not correct closer, string is invalid.
          return false;
        }
      } else {
        //Since curreny element is opener add it to checkerList.
        checker.add(e);
      }
    }

    //After traversing is done, if there are still elements in checkerList, it is invalid. Else it is valid.
    return checker.isEmpty;
  }
}


////Algorithm////