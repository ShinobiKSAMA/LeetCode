public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        //Initialize Summation variable.
        int finalValue = 0;

        //Traverse through the operations list.
        foreach (string x in operations) {
            //If current operations contains '+', increment finalValue by 1. Else do the decrement by 1.
            finalValue += x.Contains("+") ? 1 : -1;
        }

        //After traversing is completed, return latest value of summation variable
        return finalValue;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] operations = new string[] {"X++", "++X", "X--"};
        Console.WriteLine(sol.FinalValueAfterOperations(operations));
    }
}