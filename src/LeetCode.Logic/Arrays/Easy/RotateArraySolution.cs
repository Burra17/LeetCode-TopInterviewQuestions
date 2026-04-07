namespace LeetCode.Logic.Arrays.Easy
{
    // https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
    public class RotateArraySolution
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length; // Handle cases where k is greater than the length of the array
            Reverse(nums, 0, nums.Length - 1); // Reverse the entire array
            Reverse(nums, 0, k - 1); // Reverse the first k elements
            Reverse(nums, k, nums.Length - 1); // Reverse the remaining elements
        }

        private void Reverse(int[] nums, int start, int end) // Helper method to reverse a portion of the array
        {
            while (start < end) // Swap elements at start and end indices
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
