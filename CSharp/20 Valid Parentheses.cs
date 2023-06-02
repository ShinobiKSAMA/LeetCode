public class Solution {
    public bool IsValid(string s) {
        //Declare Common Romans and their correspondents
        Dictionary<char, char> relations = new Dictionary<char, char>();
        relations.Add(')','(');
        relations.Add('}','{');
        relations.Add(']','[');

        //CheckerStack to store the openings.
        Stack<char> checker = new Stack<char>();

        //Traverse through all the characters from given string.
        foreach (char e in s) {
            //If current element is closer
            if(relations.ContainsKey(e)) {
                //If checkerStack has elements in it and current element is closer for last element at checkerStack.
                if (checker.Count > 0 && checker.Peek() == relations[e]) {
                    //Remove the last element, since it is correctly closed.
                    checker.Pop();
                } else {
                    //If current element is not correct closer, string is invalid.
                    return false;
                }
            } else {
                //Since current element is opener add it to checkerStack.
                checker.Push(e);
            }
        }

        //After traversing is done, if there are still elements in checkerStack, it is invalid. Else it is valid.
        return checker.Count == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.IsValid("((]))"));
    }
}