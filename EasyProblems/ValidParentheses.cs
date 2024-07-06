namespace EasyProblems;

//https://leetcode.com/problems/valid-parentheses/
public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var bracketPairs = new Dictionary<char, char>() { { ')', '(' }, { ']', '[' }, { '}', '{' } };

        foreach (var character in s)
        {
            if (bracketPairs.TryGetValue(character, out var pair))
            {
                if (stack.Count != 0 && stack.Peek() == pair)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(character);
            }
           
        }

        return stack.Count == 0;
    }
}