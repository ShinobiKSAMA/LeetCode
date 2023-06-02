public class Solution {
    public bool IsPalindrome(int x) {
        //Integer variable to create reverse of the number.
        int rev = 0;

        //Temp variable to calculate reverse.
        int tmp = x;

        //Until tmp becomes 0, keep destroying the tmp.
        while (tmp > 0) {
            //Store new value after destruction
            int digit = tmp % 10;
            //Add that digit to already stored rev.
            rev = rev * 10 + digit;
            //And get after remainder.
            tmp /= 10;
        }

        //If rev and x are still same, it is Palindrome
        return rev == x;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.IsPalindrome(547));
    }
}