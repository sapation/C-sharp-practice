namespace Leetcode_Practice
{
    public class MinSizeSubsarraySum
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int minLength = int.MaxValue;
            int left = 0;
            int currentSum = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                currentSum += nums[right];

                while(currentSum >= target)
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    currentSum -= nums[left];
                    left++;
                }
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }
    }
}

// int target = 7;
// int[] nums = [2,3,1,2,4,3];

// MinSizeSubsarraySum minSizeSubsarraySum = new();

// int result = minSizeSubsarraySum.MinSubArrayLen(target, nums);
// Console.WriteLine($"Length of array: {result}");
