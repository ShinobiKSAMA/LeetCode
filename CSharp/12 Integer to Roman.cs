public class Solution {
    public string IntToRoman(int num) {
        //List of Romans for Thousands
        string[] thousands = {"", "M", "MM", "MMM"};

        //List of Romans for Hundreds
        string[] hundreds = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};

        //List of Romans for Tens
        string[] tens = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};

        //List of Romans for Ones
        string[] ones = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};

        //Concatenation of all numbers' roman correspondent
        return thousands[num/1000] + //get 1000th place
        hundreds[num%1000 / 100] + //get 100th place
        tens[num%100 / 10] + //get 10th place
        ones[num%10]; //get 1st place
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.IntToRoman(743));
    }
}