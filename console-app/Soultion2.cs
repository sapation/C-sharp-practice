using System.Diagnostics.Tracing;

namespace console_app
{
    public class Soultion2
    {
        public bool ContainsDuplicate1(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

         public bool ContainsDuplicate2(int[] nums)
        {
            HashSet<int> set = new();
            for(int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                } else
                {
                    set.Add(nums[i]);
                }
            }

            return false;
        }
    }
}