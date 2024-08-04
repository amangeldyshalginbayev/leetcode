namespace EasyProblems;

//https://leetcode.com/problems/sqrtx/
public class Problem69
{
    public int MySqrt(int x)
    {
        var left = 0;
        var right = x;
        var res = 0;

        while (left <= right)
        {
            var mid = left + (right - left)/2;
            
            if (Math.Pow(mid,2) > x)
            {
                right = mid - 1;
            }
            else if (Math.Pow(mid,2) < x)
            {
                left = mid + 1;
                res = mid;
            }
            else
            {
                return mid;
            }
            
        }

        return res;
    }
}