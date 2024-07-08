using System.Text;

namespace EasyProblems3daysRecap;

//https://leetcode.com/problems/longest-common-prefix/
public class LongestCommonPrefixProblem
{
    public string LongestCommonPrefix(string[] strs)
    {
        var commonPrefix = new StringBuilder();

        for (var i = 0; i < strs[0].Length; i++)
        {
            foreach (var word in strs)
            {
                if (i == word.Length || word[i] != strs[0][i])
                {
                    return commonPrefix.ToString();
                }
            }

            commonPrefix.Append(strs[0][i]);
        }

        return commonPrefix.ToString();
    }
}