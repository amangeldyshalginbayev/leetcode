namespace EasyProblems;

//https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class RemoveDuplicatesFromSortedArrayProblem
{
    public int RemoveDuplicates(int[] nums)
    {
        var leftPointer = 1;

        for (var rightPointer = 1; rightPointer < nums.Length; rightPointer++)
        {
            if (nums[rightPointer] != nums[rightPointer - 1])
            {
                nums[leftPointer] = nums[rightPointer];
                leftPointer += 1;
            }
        }

        return leftPointer;
    }
}