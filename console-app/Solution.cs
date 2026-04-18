namespace console_app
{
    public class Solution
    {
        public int[] Twosum1(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        return new int[] {i, j};
                    }
                };
            }
            throw new ArgumentException("No Solution");
        }


        public int[] Twosum2(int[] nums, int target)
        {
            //[2,7,11,15];
            Dictionary<int, int> dict = new();
            for(int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] {dict[complement], i};
                }

                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            throw new ArgumentException("No Solution");
        }
    }

}