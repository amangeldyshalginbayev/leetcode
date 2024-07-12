namespace EasyProblems3daysRecap;

//https://leetcode.com/problems/valid-parentheses/
public class ValidParenthesesProblem
{
    public bool IsValid(string s)
    {
        var closingPairs = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        var stack = new Stack<char>();

        foreach (var character in s)
        {
            if (closingPairs.TryGetValue(character, out var value) && stack.TryPeek(out var top) && value == top)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(character);
            }
        }

        return stack.Count == 0;
    }
}