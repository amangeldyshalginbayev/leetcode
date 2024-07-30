namespace EasyProblems3daysRecap;

public class Problem58
{
    public int LengthOfLastWord(string s)
    {

        var index = s.Length - 1;

        while (index >= 0 && s[index] == ' ')
        {
            index -= 1;
        }

        var start = index;

        while (start >= 0 && s[start] != ' ')
        {
            start -= 1;
        }

        return index - start;

    }
}