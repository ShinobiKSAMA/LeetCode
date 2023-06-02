public class Solution {
    public int RomanToInt(string s) {
        //Declare Common Romans and their correspondents
        Dictionary<char, int> roman = new Dictionary<char, int>();
        roman.Add('I',1);
        roman.Add('V',5);
        roman.Add('X',10);
        roman.Add('L',50);
        roman.Add('C',100);
        roman.Add('D',500);
        roman.Add('M',1000);

        //Store Length in variable
        int n = s.Length;

        //Get last place's correspondent
        int result = roman[s[n-1]];
        
        //Traverse through remaining String in reverse order
        for (int i = n-2; i>=0; i--) {
            //Check if current and right value are same
            result = roman[s[i]] >= roman[s[i+1]]
            //If yes add current's correspondent to result
            ? result + roman[s[i]]
            //If no subtract current's correspondent from result
            : result - roman[s[i]];
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.RomanToInt("DCCXLIII"));
    }
}