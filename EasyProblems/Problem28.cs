namespace EasyProblems;

//https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
public class Problem28
{
    public int StrStr(string haystack, string needle)
    {
        for (var i = 0; i < haystack.Length + 1 - needle.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                var valid = true;
                
                for (var j = 0; j < needle.Length; j++)
                {
                    if (haystack[i+j] != needle[j])
                    {
                        valid = false;
                    }
                }

                if (valid)
                    return i;
            }
        }

        return -1;
    }

    //This is not memory efficient, creates string of length needle.Length while iterating over outer loop
    public int StrStrRefactored(string haystack, string needle)
    {
        if (needle == "")
        {
            return 0;
        }

        for (var i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack.Substring(i, needle.Length) == needle)
            {
                return i;
            }
        }

        return -1;
    }
}