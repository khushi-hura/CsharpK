namespace DataStructures
{
    public class Array
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int n = nums.Length;
            Dictionary<int, int> idx = new Dictionary<int, int>();
            for (int i = 0; i < n; ++i)
            {
                int diff = target - nums[i];
                if (idx.ContainsKey(diff))
                {
                    return [idx[diff], i];
                }
                idx[nums[i]] = i;
            }
            return [];
        }
    }
}
