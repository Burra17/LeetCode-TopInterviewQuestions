namespace LeetCode.Logic.Arrays.Easy
{
    // https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/578/
    public class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in nums)
            {
                // if the number exists we have a duplicate
                if (seen.Contains(num))
                {
                    return true;
                }
                // otherwise add for future comparisons
                seen.Add(num);
            }
            return false;
        }
    }
}
