namespace Leetcode_Practice
{
    public class TwoSum
    {
        public int[] TwoSumArray(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while(low < high)
            {
                int sum = nums[low] + nums[high];
                if (sum == target)
                {
                    return new int[] {low + 1, high + 1};
                } else if(sum < target)
                {
                    low++;
                } else
                {
                    high--;
                }
            }

            return new int[] {-1, -1};
        }
    }
}

/**
* Two pointer questions
*
*/

// int[] numbers = [2,7,11,15];
// int target = 9;

// TwoSum twosum = new();

// int[] result = twosum.TwoSumArray(numbers, target);
// Console.WriteLine($"index1: {result[0]} and index2: {result[1]}");
