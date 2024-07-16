namespace EasyProblems;

public class Problem58
{
    public int LengthOfLastWord(string s)
    {
        var i = s.Length - 1;
        var length = 0;

        while (s[i] == ' ')
        {
            i -= 1;
        }

        while (i >= 0 && s[i] != ' ')
        {
            length += 1;
            i -= 1;
        }

        return length;
    }
}