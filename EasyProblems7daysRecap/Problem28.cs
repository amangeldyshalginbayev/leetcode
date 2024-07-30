namespace EasyProblems7daysRecap;

public class Problem28
{
    public int StrStr(string haystack, string needle) {

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                var valid = true;
                for (int j = 0; j < needle.Length; j++)
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