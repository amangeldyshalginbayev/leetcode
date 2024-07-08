namespace EasyProblems3daysRecap;

//https://leetcode.com/problems/two-sum/
public class TwoSumProblem
{
    public int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length == 2)
        {
            return [0, 1];
        }

        var numberIndexes = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var remainder = target - nums[i];

            if (numberIndexes.TryGetValue(remainder, out var index))
            {
                return [index, i];
            }

            numberIndexes[nums[i]] = i;
        }

        return [];
    }
}