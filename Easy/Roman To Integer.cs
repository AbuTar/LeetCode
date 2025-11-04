public class Solution 
{
    public int RomanToInt(string s) 
    {
        string romanString = s;
        Dictionary<char, int> Conversion = new Dictionary<char, int>()
        {   
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        int romanNumber = 0;
        for(int i = 0; i < romanString.Length; i++)
        {
            if (i + 1 < romanString.Length && Conversion[romanString[i]] < Conversion[romanString[i + 1]])
            {
                romanNumber -= Conversion[romanString[i]];
            }
            else
            {
                romanNumber += Conversion[romanString[i]];
            }
        }
        return romanNumber;
    }
}