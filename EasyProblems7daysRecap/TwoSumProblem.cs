namespace EasyProblems7daysRecap;

public class TwoSumProblem
{
    public int[] TwoSum(int[] nums, int target)
    {
        var numberIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numberIndex.TryGetValue(complement, out int index))
            {
                return [index, i];
            }
            else
            {
                numberIndex[nums[i]] = i;
            }
        }

        return [];
    }
}