namespace EasyProblems7daysRecap;

//https://leetcode.com/problems/valid-parentheses/
public class Problem20
{
    public bool IsValid(string s)
    {

        var closingPairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        var stack = new Stack<char>();

        foreach (var t in s)
        {
            if (stack.TryPeek(out var top) && closingPairs.TryGetValue(t, out var pair) && top == pair)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(t);
            }
        }

        return stack.Count == 0;
    }
}