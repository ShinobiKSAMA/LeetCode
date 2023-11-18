class Solution {
  List<List<String>> groupAnagrams(List<String> strs) {
    //Create new Empty Dictionary
    Map<String, List<String>> dictionary = {};

    //Traverse to each word in array
    strs.forEach((word) {
      //Sort each word and treat it as key for dictionary
      final key = String.fromCharCodes(word.runes.toList()..sort());

      //Check if key already exist in Dictionary
      //If yes, just append new word in list
      //If not, just create Empty list and key mapping, and then append the word.
      dictionary.putIfAbsent(key, () => []).add(word);
    });

    //Return List of all List in Dictionary
    return dictionary.values.toList();
  }
}
