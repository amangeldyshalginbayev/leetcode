namespace EasyProblems7daysRecap;

public class Problem58
{
    public int LengthOfLastWord(string s)
    {
        var end = s.Length - 1;

        while (s[end] == ' ' && end > 0)
        {
            end -= 1;
        }

        var length = 0;

        while (end >= 0 && s[end] != ' ')
        {
            length += 1;
            end -= 1;
        }

        return length;
    }
}