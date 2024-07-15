namespace EasyProblems;

//https://leetcode.com/problems/search-insert-position/
public class Problem35
{
    public int SearchInsert(int[] nums, int target)
    {
        var leftPointer = 0;
        var rightPointer = nums.Length - 1;

        while (leftPointer <= rightPointer)
        {
            var mid = (leftPointer + rightPointer) / 2;

            if (target == nums[mid])
            {
                return mid;
            }

            if (target > nums[mid])
            {
                leftPointer = mid + 1;
            }
            else
            {
                rightPointer = mid - 1;
            }
        }

        return leftPointer;
    }
}