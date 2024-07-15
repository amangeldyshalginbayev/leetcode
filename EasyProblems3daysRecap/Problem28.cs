namespace EasyProblems3daysRecap;

public class Problem28
{
    public int StrStr(string haystack, string needle) {
        if (string.IsNullOrEmpty(needle))
        {
            return 0;
        }

        for (var i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                var valid = true;
                for (var j = 1; j < needle.Length; j++)
                {
                    if (haystack[i+j] != needle[j])
                    {
                        valid = false;
                    }
                }

                if (valid)
                {
                    return i;
                }
            }
        }

        return -1;
    }
}