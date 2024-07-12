namespace EasyProblems7daysRecap;

public class LongestCommonPrefixProblem
{
    public string LongestCommonPrefix(string[] strs)
    {
        var commonPrefix = "";

        for (var i = 0; i < strs[0].Length; i++)
        {
            foreach (var word in strs)
            {
                if (i == word.Length || strs[0][i] != word[i])
                {
                    return commonPrefix;
                }
            }

            commonPrefix += strs[0][i];
        }

        return commonPrefix;
    }
}