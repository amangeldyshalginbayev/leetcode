namespace EasyProblems;

//https://leetcode.com/problems/palindrome-number/description/
public class PalindromeNumber
{
    public static bool IsPalindromeLoopOverString(int x)
    {
        var number = x.ToString();
    
        for (int i = 0, j = number.Length - 1; i <= number.Length / 2; i++, j--)
        {
            if (number[i] != number[j])
                return false;
        }
    
        return true;
    }
    
    public static bool IsPalindromeReverseString(int x)
    {
        if (x < 0)
        {
            return false; 
        }
        
        var stringNumber = x.ToString();
        
        var charArray = stringNumber.ToCharArray();
        Array.Reverse(charArray);
        var reversedNumber =  new string(charArray);

        return stringNumber == reversedNumber;

    }

    public static bool IsPalindromeReverseNumber(int x)
    {
        if (x < 0)
        {
            return false;
        }

        return false;
    }
}