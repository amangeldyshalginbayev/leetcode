namespace EasyProblems7daysRecap;

public class Problem66
{
    public int[] PlusOne(int[] digits)
    {
        digits = digits.Reverse().ToArray();

        var residue = 1;

        for (var i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 9 && residue == 1)
            {
                digits[i] = 0;
            }
            
            else if (residue == 1)
            {
                digits[i] += 1;
                residue = 0;
            }
        }

        if (residue == 1)
        {
            digits = digits.Append(1).ToArray();
        }

        return digits.Reverse().ToArray();
    }
}