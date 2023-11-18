public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        //Create new Empty Dictionary
        Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();

        //Traverse to each word in array
        foreach (var word in strs)
        {
            // Sort each word and treat it as a key for the dictionary
            var key = new string(word.OrderBy(c => c).ToArray());

            // Check if the key already exists in the dictionary
            // If yes, just append the new word to the list
            // If not, create an empty list and key mapping, and then append the word
            if (dictionary.ContainsKey(key))
            {
                dictionary[key].Add(word);
            }
            else
            {
                dictionary[key] = new List<string> { word };
            }
        }

        // Return a list of all lists in the dictionary
        return dictionary.Values.ToList<IList<string>>();
    }
}