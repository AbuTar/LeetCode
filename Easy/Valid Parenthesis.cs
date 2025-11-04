public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0)
                {
                    return false; // Unbalanced closing bracket found
                }

                char openingBracket = stack.Pop();
                if ((openingBracket == '(' && c != ')') ||
                    (openingBracket == '{' && c != '}') ||
                    (openingBracket == '[' && c != ']'))
                {
                    return false; // Mismatched opening and closing brackets
                }
            }
        }

        return stack.Count == 0; // If stack is empty, all brackets are balanced
    }
}
