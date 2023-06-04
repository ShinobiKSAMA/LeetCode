public class Solution {
    public int MyAtoi(string s) {
        //Enumeration variable.
        int idx = 0;
        
        //Variable to store result.
        long result = 0;

        //Boolean to decide sign.
        bool isNeg = false;

        //Untill there are white spaces, keep incrementing.
        while(idx < s.Length && char.IsWhiteSpace(s[idx]))  idx++;
        
        //If we encounter sign, change boolean value and increment.
        if (idx < s.Length && (s[idx] == '-' || s[idx] == '+')) {
            isNeg = s[idx] == '-';
            idx++;
        }

        //Untill we keep encountering digits, keep adding it to result.
        while(idx < s.Length && char.IsDigit(s[idx])) {
            //Converting characters to numbers.
            result = result * 10 + s[idx] - '0';
            
            //If value exceeds MaxValue, break the loop.
            if(result > int.MaxValue) break;

            //Keep incrementing index.
            idx++;
        }

        //If value needs to be negative, convert it.
        result = isNeg ? -result : result;

        //If values are max, return MaxValue.
        if (result > int.MaxValue)
            result = int.MaxValue;

        //If values are min, return MinValue.
        if (result < int.MinValue)
            result = int.MinValue;

        //Parse it to integer and return.
        return (int)result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.MyAtoi("4193 with words"));
    }
}