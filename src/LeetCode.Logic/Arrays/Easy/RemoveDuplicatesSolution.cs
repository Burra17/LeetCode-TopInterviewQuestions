namespace LeetCode.Logic.Arrays.Easy;

public class RemoveDuplicatesSolution
{
    // https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/
    public int RemoveDuplicates(int[] nums) 
    {
        // If the array is empty, there are no elements to process, so we return 0.
        if (nums.Length == 0) return 0;

        int k = 1; // Initialize k to 1 because the first element is always unique.

        // Iterate through the array starting from the second element (index 1).
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1]) // If the current element is different from the previous one, it means it's a unique element.
            {
                nums[k] = nums[i]; // Move the unique element to the position indicated by k.
                k++; // Increment k to point to the next position for the next unique element.
            }
        }

        return k; // Return k, which represents the number of unique elements in the array.
    }
}