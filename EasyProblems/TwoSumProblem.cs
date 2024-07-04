namespace EasyProblems;

//https://leetcode.com/problems/two-sum/
public class TwoSumProblem
{
    public int[] TwoSumBruteForce(int[] nums, int target)
    {
        if (nums.Length == 2)
            return [0, 1];

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return [i, j];
            }
        }

        return [];
    }

    public static int[] TwoSumEfficient(int[] nums, int target)
    {
        if (nums.Length == 2)
            return [0, 1];

        Dictionary<int, int> table = new();

        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (table.ContainsKey(complement))
            {
                return new[] { table[complement], i };
            }
            else
            {
                table[nums[i]] = i;
            }
        }

        return [];
    }
}