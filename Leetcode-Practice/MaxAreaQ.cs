namespace Leetcode_Practice
{
    public class MaxAreaQ
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while(left < right)
            {
                int width = right - left;
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * width);

                if (height[left] <= height[right])
                {
                    left++;
                } else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}

// int[] heights = [1,8,6,2,5,4,8,3,7];

// MaxAreaQ maxAreaQ = new();
// int result = maxAreaQ.MaxArea(heights);
// Console.WriteLine($"Result is : {result}");