namespace EasyProblems3daysRecap;

//https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class Problem26
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 1;
        }

        var leftPointer = 1;
        
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i-1])
            {
                nums[leftPointer] = nums[i];
                leftPointer++;
            }
        }
        
        return leftPointer;
    }
}