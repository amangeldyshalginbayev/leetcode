namespace EasyProblems3daysRecap;

public class Problem66
{
    public int[] PlusOne(int[] digits)
    {
        digits = digits.Reverse().ToArray();
        var carry = 1;
        var i = 0;

        while (carry == 1)
        {
            if (i < digits.Length)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                    i += 1;
                }
                else
                {
                    digits[i] += 1;
                    carry = 0;
                }
            }
            else
            {
                digits = digits.Append(1).ToArray();
                carry = 0;
            }
        }
        return digits.Reverse().ToArray();
    }
}