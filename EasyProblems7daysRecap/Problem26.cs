namespace EasyProblems7daysRecap;

public class Problem26
{
    public int RemoveDuplicates(int[] nums)
    {

        var leftPointer = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i-1])
            {
                nums[leftPointer] = nums[i];
                leftPointer += 1;
            }
        }

        return leftPointer;
    }
}